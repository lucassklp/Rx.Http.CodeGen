using CaseConverter;
using Fluent.CodeGen;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System.CodeDom.Compiler;
using System.Text;

namespace Rx.Http.CodeGen
{
    public class ConsumerGenerator
    {
        private ConsumerGenerationConfig config;
        private OpenApiDocument openApiDocument;
        public List<ClassGen> ModelClassesGen { get; private set; }
        public ClassGen ConsumerClassGen { get; private set; }
        public ClassGen? TokenInterceptorClassGen { get; private set; }

        public ConsumerGenerator(ConsumerGenerationConfig config)
        {
            this.config = config;
            openApiDocument = new OpenApiStringReader().Read(config.OpenApiDefinition, out var _);
            ModelClassesGen = GenerateModelsClassGen();
            ConsumerClassGen = GenerateConsumer();
        }

        private string? ExtractType(OpenApiSchema? element)
        {
            if(element is null)
            {
                return null;
            }
            
            string type = TypeMapping.GetAssociatedType(element);
            if (type == "List<object>")
            {
                if(element.Items is not null)
                {
                    var subtype = TypeMapping.GetAssociatedType(element.Items);
                    type = $"List<{subtype}>";
                }
            }

            if(TypeMapping.HasUnderlyingType(type))
            {
                return $"Models.{type}";
            }

            if(type == "object")
            {
                return config.Type;
            }

            if(type == "List<object>")
            {
                return $"List<{config.Type}>";
            }

            return type;
        }
        
        private ClassGen GenerateModelClasses(string name, OpenApiSchema schema)
        {
            var modelClassGen = new ClassGen(name: name.ToPascalCase())
                .Namespace($"{config.Namespace}.Models")
                .Using("Newtonsoft.Json")
                .Public();

            void AddProperties(IDictionary<string, OpenApiSchema> properties)
            {
                foreach (var property in properties)
                {
                    var type = ExtractType(property.Value);

                    var propertyName = property.Key.ToPascalCase();

                    if(char.IsDigit(propertyName.First()))
                    {
                        propertyName = $"_{propertyName}";
                    }

                    var propertyGen = new PropertyGen(name: propertyName, type: type!)
                        .Public()
                        .WithAttributes($"""[JsonProperty("{property.Key}")]""");

                    modelClassGen.WithProperty(propertyGen);
                }
            }

            AddProperties(schema.Properties);

            foreach (var subschema in schema.AllOf)
            {
                AddProperties(subschema.Properties);
            }

            Logger.LogVerbose(modelClassGen.GenerateCode);

            return modelClassGen;
        }
        
        private void GenerateConstructor(ClassGen classGen, OpenApiDocument openApi)
        {
            classGen.Constructor(ctor =>
            {
                ctor.Public()
                    .WithParameter("HttpClient", "httpClient")
                    .WithBase("httpClient", "null");


                var body = new StringBuilder();
                if (openApi.Servers.Any())
                {
                    body.AppendLine($"""httpClient.BaseAddress = new Uri("{ openApi.Servers.First().Url }");""");
                }

                if(openApi.Components.SecuritySchemes.Any(x => x.Value.Type == SecuritySchemeType.Http && x.Value.Scheme == "bearer"))
                {
                    body.AppendLine($"""RequestInterceptors.Add(new {config.ConsumerName}TokenInterceptor());""");
                    TokenInterceptorClassGen = GenerateTokenInterceptor();
                }

                ctor.WithBody(body.ToString());

            });
        }

        private ClassGen GenerateTokenInterceptor()
        {
            Logger.LogVerbose("Generating token interceptor");

            var interceptMethod = new MethodGen("Intercept")
                .Public()
                .WithParameter("RxHttpRequestOptions", "request")
                .WithBody("""
                // Implement your logic to handle your token here
                request.UseBearerAuthorization("token");
                """);

            var tokenInterceptorGen = new ClassGen($"{config.ConsumerName}TokenInterceptor")
                .Using("Rx.Http", "Rx.Http.Extensions", "Rx.Http.Interceptors")
                .Namespace(config.Namespace!)
                .Implements("RxRequestInterceptor")
                .WithMethod(interceptMethod);
            
            Logger.LogVerbose(tokenInterceptorGen.GenerateCode);
            
            return tokenInterceptorGen;
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

            var alternativeName = httpMethod.ToPascalCase() + route.ToPascalCase().Replace("/", string.Empty);

            var methodGen = new MethodGen(name: operation.OperationId?.ToPascalCase() ?? alternativeName, returnType: $"IObservable<{type ?? "RxHttpResponse"}>")
                .Public();

            var @base = GetBase(httpMethod);

            var argumentType = string.IsNullOrEmpty(type) ? "" : $"<{type}>";

            if (operation.RequestBody is null)
            {
                var options = GenerateOptions(operation);
                if (options is null)
                {
                    body = $"""
                        return {@base}{httpMethod.ToPascalCase()}{argumentType}($"{route}");
                        """;
                }
                else
                {
                    body = $"""
                        return {@base}{httpMethod.ToPascalCase()}{argumentType}($"{route}", null, {options});
                        """;
                }
            }
            else
            {
                string bodyType = "object";
                string bodyArgument = "body";

                if (operation.RequestBody.Content.Any(x => x.Key == "application/json"))
                {
                    var bodySchema = operation.RequestBody.Content["application/json"].Schema;
                    bodyType = ExtractType(bodySchema) ?? "object";
                    bodyArgument = "body";

                    methodGen.WithParameter(bodyType, "body");
                }
                else if (operation.RequestBody.Content.Any(x => x.Key == "application/x-www-form-urlencoded"))
                {
                    var bodySchema = operation.RequestBody.Content["application/x-www-form-urlencoded"].Schema;
                    var objectMap = new List<string>();

                    foreach (var parameter in bodySchema.Properties)
                    {
                        var name = parameter.Key;
                        var paramType = ExtractType(parameter.Value);
                        methodGen.WithParameter(name: name.ToCamelCase(), type: paramType);
                        var toString = paramType == "string" ? "" : ".ToString()";
                        objectMap.Add($$"""
                            { "{{parameter.Key}}", {{parameter.Key}}{{toString}} }
                        """);
                    }

                    bodyArgument = $$"""
                    new FormUrlEncodedContent(new Dictionary<string, string>
                    {
                    {{string.Join(",\n", objectMap)}}
                    })
                    """;
                }
                else if (operation.RequestBody.Content.Any(x => x.Key == "multipart/form-data"))
                {
                    methodGen.WithParameter("MultipartFormDataContent", "body");
                }
                else if (operation.RequestBody.Content.Any(x => x.Key == "text/plain"))
                {
                    methodGen.WithParameter("string", "body");
                }

                var options = GenerateOptions(operation);

                if (options is null)
                {
                    body = $"""
                        return {@base}{httpMethod.ToPascalCase()}{argumentType}($"{route}", {bodyArgument});
                        """;
                }
                else
                {
                    body = $"""
                        return {@base}{httpMethod.ToPascalCase()}{argumentType}($"{route}", {bodyArgument}, {options});
                        """;
                }
            }

            methodGen.WithBody(body);

            foreach (var parameter in operation.Parameters)
            {
                var name = parameter.Name;
                var paramType = ExtractType(parameter.Schema);
                methodGen.WithParameter(name: name.ToCamelCase(), type: paramType);
            }

            foreach (var parameter in path.Parameters)
            {
                var name = parameter.Name;
                var paramType = ExtractType(parameter.Schema);
                methodGen.WithParameter(name: name.ToCamelCase(), type: paramType);
            }

            return methodGen;
        }

        private string GetBase(string httpMethod)
        {
            var operationIds = openApiDocument.Paths.SelectMany(c => c.Value.Operations)
                .Select(x => x.Value)
                .Select(x => x.OperationId?.ToPascalCase())
                .Where(x => !string.IsNullOrWhiteSpace(x));
            
            return operationIds.Any(x => x == httpMethod.ToPascalCase()) ? "base." : string.Empty;
        }

        private void GenerateFile(string path, string content) 
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(content);
            file.Close();
        }

        private string GenerateConsumerName() => $"{config.ConsumerName}Consumer";

        public ClassGen GenerateConsumer()
        {
            var className = GenerateConsumerName();

            var classGen = new ClassGen(className)
                .Extends("RxHttpClient")
                .Namespace(config.Namespace!)
                .Using("System", "Rx.Http", "Rx.Http.Extensions", $"{config.Namespace}.Models");

            GenerateConstructor(classGen, openApiDocument);

            foreach (var path in openApiDocument.Paths)
            {
                foreach (var operation in path.Value.Operations)
                {

                    var method = GenerateMethod(path.Key.ToCamelCase(), path.Value, operation.Key.GetDisplayName(), operation.Value);
                    classGen.WithMethod(method);
                    
                }
            }

            Logger.LogVerbose(classGen.GenerateCode);

            return classGen;
        }

        private List<ClassGen> GenerateModelsClassGen()
        {
            return openApiDocument.Components.Schemas
                .Select(schema => GenerateModelClasses(schema.Key, schema.Value))
                .ToList();
        }

        private void GenerateModelFiles(ClassGen classGen)
        {
            var modelFileDir = Path.Combine(config.Path!, "Models", $"{classGen.ClassName}.cs");
            var content = classGen.GenerateCode();
            GenerateFile(modelFileDir, content);
        }

        public void GenerateFiles()
        {
            if (Directory.Exists(config.Path))
            {
                Directory.Delete(config.Path, true);
            }

            Directory.CreateDirectory(Path.Combine(config.Path!, "Models"));

            // Create model files
            ModelClassesGen.ForEach(GenerateModelFiles);

            // Create token interceptor file
            if(TokenInterceptorClassGen != null)
            {
                var tokenInterceptorDir = Path.Combine(config.Path!, config.ConsumerName + "TokenInterceptor.cs");
                GenerateFile(tokenInterceptorDir, TokenInterceptorClassGen.GenerateCode());
            }

            // Create consumer files
            var consumerFileDir = Path.Combine(config.Path!, $"{ConsumerClassGen.ClassName}.cs");
            GenerateFile(consumerFileDir, ConsumerClassGen.GenerateCode());
        }
    }
}
