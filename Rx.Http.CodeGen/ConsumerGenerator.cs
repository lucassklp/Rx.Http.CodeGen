using CaseConverter;
using Fluent.CodeGen;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System.CodeDom.Compiler;

namespace Rx.Http.CodeGen
{
    public class ConsumerGenerator
    {
        private string @namespace;
        private OpenApiDocument openApiDocument;
        private string defaultType;
        private string path;
        private string consumerName;

        public ConsumerGenerator(string path, string @namespace, string openApiDefinition, string consumerName, string defaultType = "object")
        {
            this.@namespace = @namespace;
            this.defaultType = defaultType;
            openApiDocument = new OpenApiStringReader().Read(openApiDefinition, out var _);
            this.path = path;
            this.consumerName = consumerName;
        }

        private string? ExtractType(OpenApiSchema? element)
        {
            if (element is null)
            {
                return null;
            }

            var type = Consts.TypesMap[element.Type];

            if (type == "object")
            {
                type = element?.Reference?.Id?.ToPascalCase() ?? defaultType;
            }
            else if (type == "List<object>")
            {
                var subtype = element?.Items?.Reference?.Id?.ToPascalCase() ?? element?.Items?.Type ?? "object";
                type = $"List<{subtype}>";
            }

            return type;
        }
        
        private ClassGen GenerateModelClasses(string name, OpenApiSchema schema)
        {
            var modelClassGen = new ClassGen(name: name.ToPascalCase())
                .Namespace(@namespace)
                .Public();

            var properties = schema.Properties;

            foreach (var property in properties)
            {
                var type = ExtractType(property.Value);

                var fieldGen = new FieldGen(name: property.Key.ToPascalCase(), type: type)
                    .Public();

                modelClassGen.WithField(fieldGen);
            }

            return modelClassGen;
        }
        
        private void GenerateConstructor(ClassGen classGen, OpenApiDocument openApi)
        {
            classGen.Constructor(ctor =>
            {
                ctor.Public()
                    .WithParameter("HttpClient", "httpClient")
                    .WithBase("httpClient", "null");

            });
        }
        
        private string? GenerateOptions(OpenApiOperation operation)
        {
            List<string> queryParams = operation.Parameters.Where(x => x.In == ParameterLocation.Query)
                .Select(x => $"options.AddQueryString(\"{x.Name}\", {x.Name.ToCamelCase()});")
                .ToList();

            List<string> headerParams = operation.Parameters.Where(x => x.In == ParameterLocation.Header)
                .Select(x => $"options.AddHeader(\"{x.Name}\", {x.Name.ToCamelCase()});")
                .ToList();

            if (queryParams.Any() || headerParams.Any())
            {
                var stringWriter = new StringWriter();
                var indentedTextWriter = new IndentedTextWriter(stringWriter);
                indentedTextWriter.Indent++;

                var optionsParameters = new List<string>();
                optionsParameters.AddRange(queryParams);
                optionsParameters.AddRange(headerParams);

                optionsParameters.ForEach(indentedTextWriter.WriteLine);

                return $$"""
            options => {
                {{stringWriter.GetStringBuilder()}}}
            """;
            }

            return null;
        }

        private MethodGen GenerateMethod(string route, OpenApiPathItem path, string httpMethod, OpenApiOperation operation)
        {
            OpenApiSchema? schema = operation.Responses?.Where(x => x.Key == "200")
                .Select(x => x.Value)?
                .FirstOrDefault()?.Content?
                .Where(x => x.Key == "application/json")?
                .Select(x => x.Value)?
                .FirstOrDefault()?.Schema;

            string? type = ExtractType(schema);

            var body = string.Empty;

            var methodGen = new MethodGen(name: operation.OperationId.ToPascalCase(), returnType: $"IObservable<{type ?? "RxHttpResponse"}>")
                .Public();

            var argumentType = string.IsNullOrEmpty(type) ? "" : $"<{type}>";

            if (operation.RequestBody is null)
            {
                var options = GenerateOptions(operation);
                if (options is null)
                {
                    body = $"""
                return base.{httpMethod.ToPascalCase()}{argumentType}($"{route}");
                """;
                }
                else
                {
                    body = $"""
                return base.{httpMethod.ToPascalCase()}{argumentType}($"{route}", null, {options});
                """;
                }
            }
            else
            {
                string bodyType = "object";
                string bodyArgument = "body";

                if (operation.RequestBody.Content.Any(x => x.Key == "application/x-www-form-urlencoded"))
                {
                    var bodySchema = operation.RequestBody.Content["application/x-www-form-urlencoded"].Schema;
                    bodyType = ExtractType(bodySchema) ?? "object";

                    var objectMap = bodySchema.Properties.Select(x => $$"""
                    { "{{x.Key}}", body.{{x.Key.ToPascalCase()}} }
                """);

                    bodyArgument = $$"""
                new FormUrlEncodedContent(new Dictionary<string, string>
                {
                {{string.Join(",\n", objectMap)}}
                }
                """;
                }

                if (operation.RequestBody.Content.Any(x => x.Key == "application/json"))
                {
                    var bodySchema = operation.RequestBody.Content["application/json"].Schema;
                    bodyType = ExtractType(bodySchema) ?? "object";
                    bodyArgument = "body";
                }

                methodGen.WithParameter(bodyType, "body");

                var options = GenerateOptions(operation);
                if (options is null)
                {
                    body = $"""
                return base.{httpMethod.ToPascalCase()}{argumentType}($"{route}", {bodyArgument});
                """;
                }
                else
                {
                    body = $"""
                return base.{httpMethod.ToPascalCase()}{argumentType}($"{route}", {bodyArgument}, {options});
                """;
                }
            }

            methodGen.WithBody(body);

            foreach (var parameter in operation.Parameters)
            {
                var name = parameter.Name;
                var paramType = Consts.TypesMap[parameter.Schema.Type];
                methodGen.WithParameter(name: name.ToCamelCase(), type: paramType);

            }

            foreach (var parameter in path.Parameters)
            {
                var name = parameter.Name;
                var paramType = Consts.TypesMap[parameter.Schema.Type];
                methodGen.WithParameter(name: name.ToCamelCase(), type: paramType);
            }

            return methodGen;
        }


        string AdjustRoute(string route)
        {
            return route.ToCamelCase();
        }


        private void GenerateFile(string path, string content) 
        {
            // Write the string to a file.
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(content);

            file.Close();
        }


        public void GenerateFiles()
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }

            Directory.CreateDirectory(path);

            foreach (var schema in openApiDocument.Components.Schemas)
            {
                var modelClass = GenerateModelClasses(schema.Key, schema.Value);
                var modelFileDir = Path.Combine(path, $"{modelClass.ClassName}.cs");
                var content = modelClass.GenerateCode();
                GenerateFile(modelFileDir, content);
            }

            //Generate the consumer
            var classGen = new ClassGen($"{consumerName}Consumer")
                .Extends("RxHttpClient")
                .Namespace(@namespace)
                .Using("System", "Rx.Http", "Rx.Http.Extensions");

            GenerateConstructor(classGen, openApiDocument);

            foreach (var path in openApiDocument.Paths)
            {
                foreach (var operation in path.Value.Operations)
                {
                    var method = GenerateMethod(AdjustRoute(path.Key), path.Value, operation.Key.GetDisplayName(), operation.Value);
                    classGen.WithMethod(method);
                }
            }

            var consumerFileDir = Path.Combine(this.path, $"{classGen.ClassName}.cs");
            GenerateFile(consumerFileDir, classGen.GenerateCode());
        }
    }
}
