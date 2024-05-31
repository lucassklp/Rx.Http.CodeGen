// See https://aka.ms/new-console-template for more information
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Fluent.CodeGen;
using CaseConverter;
using Microsoft.OpenApi.Expressions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Interfaces;
using System.CodeDom.Compiler;


var httpClient = new HttpClient();
var stream = await httpClient.GetStreamAsync("https://petstore3.swagger.io/api/v3/openapi.json");

// Read V3 as YAML
var openApiDocument = new OpenApiStreamReader().Read(stream, out var diagnostic);

//var directory = Path.Combine(Directory.GetCurrentDirectory(), "Output");

//Directory.CreateDirectory(directory);

var @namespace = "Petstore.Swagger";

var typesMap = new Dictionary<string, string>()
{
    { "int16", "short" },
    { "int32", "int" },
    { "int64", "long" },
    { "boolean", "bool" },
    { "date-time", "DateTime" },
    { "string", "string" },
    { "integer", "int" },
    { "array", "List<object>" },
    { "object", "object" },
};

string? ExtractType(OpenApiSchema? element)
{
    if(element is null)
    {
        return null;
    }

    var type = typesMap[element.Type];

    if(type == "object")
    {
        type = element?.Reference?.Id ?? "object";
    }
    else if(type == "List<object>")
    {
        var subtype = element?.Items?.Reference?.Id ?? element?.Items?.Type ?? "object";
        type = $"List<{subtype}>";
    }

    return type;
}


//Generate model classes (schemas)
ClassGen GenerateModelClasses(string name, OpenApiSchema schema)
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
    Console.WriteLine(modelClassGen.GenerateCode());
    return modelClassGen;
}


foreach (var schema in openApiDocument.Components.Schemas)
{
    GenerateModelClasses(schema.Key, schema.Value);
}


//Generate the consumer
var classGen = new ClassGen("OpenApiPetStoreConsumer")
    .Extends("RxHttpClient")
    .Namespace(@namespace)
    .Using("System", "Rx.Http", "Rx.Http.Extensions");

void GenerateConstructor(ClassGen classGen, OpenApiDocument openApi)
{
    classGen.Constructor(ctor => 
    {
        ctor.Public()
            .WithParameter("HttpClient", "httpClient")
            .WithBase("httpClient", "null");
        
    });
}

string? GenerateOptions(OpenApiOperation operation)
{
        List<string> queryParams = operation.Parameters.Where(x => x.In == ParameterLocation.Query)
            .Select(x => $"options.AddQueryString(\"{x.Name}\", {x.Name});")
            .ToList();

        List<string> headerParams = operation.Parameters.Where(x => x.In == ParameterLocation.Header)
            .Select(x => $"options.AddHeader(\"{x.Name}\", {x.Name});")
            .ToList();

        if(queryParams.Any() || headerParams.Any())
        {
            var stringWriter = new StringWriter();
            var indentedTextWriter = new IndentedTextWriter(stringWriter);
            indentedTextWriter.Indent++;

            var optionsParameters = new List<string>();
            optionsParameters.AddRange(queryParams);
            optionsParameters.AddRange(headerParams);

            optionsParameters.ForEach(x => indentedTextWriter.WriteLine(x));
            
            return $$"""
            options => {
                {{ stringWriter.GetStringBuilder() }}}
            """;
        }

        return null;
}


void GenerateMethod(string path, string httpMethod, OpenApiOperation operation)
{
    OpenApiSchema? schema = null;
    try
    {
        schema = operation.Responses["200"]?.Content["application/json"]?.Schema;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"failed to {httpMethod} {path} - {ex.Message}");
    }

    string? type = ExtractType(schema);

    var body = string.Empty;

    var methodGen = new MethodGen(name: operation.OperationId.ToPascalCase(), returnType: $"IObservable<{type ?? "RxHttpResponse"}>")
        .Public();
    
    var argumentType = string.IsNullOrEmpty(type) ? "" : $"<{type}>";
    
    if (operation.RequestBody is null)
    {
        var options = GenerateOptions(operation);
        if(options is null)
        {
            body = $"""
                return {httpMethod.ToPascalCase()}{argumentType}($"{path}");
                """;
        }
        else
        {
            body = $"""
                return {httpMethod.ToPascalCase()}{argumentType}($"{path}", null, {options});
                """;
        }
    }
    else
    {
        string bodyType = "object";

        if (operation.RequestBody.Content.Any(x => x.Key == "application/json"))
        {
            var bodySchema = operation.RequestBody.Content["application/json"].Schema;
            bodyType = ExtractType(bodySchema) ?? "object";
        }
        
        methodGen.WithParameter(bodyType, "body");
        

        var options = GenerateOptions(operation);
        if(options is null)
        {
            body = $"""
                return {httpMethod.ToPascalCase()}{argumentType}($"{path}", body);
                """;

        }
        else
        {
            body = $"""
                return {httpMethod.ToPascalCase()}{argumentType}($"{path}", body, {options});
                """;
        }
    }

    methodGen.WithBody(body);

    foreach (var parameter in operation.Parameters)
    {
        var name = parameter.Name;
        var paramType = typesMap[parameter.Schema.Type];
        methodGen.WithParameter(name: name, type: paramType);
            
    }
    classGen.WithMethod(methodGen);
}

GenerateConstructor(classGen, openApiDocument);

foreach(var path in openApiDocument.Paths)
{
    foreach(var operation in path.Value.Operations)
    {
        GenerateMethod(path.Key, operation.Key.GetDisplayName(), operation.Value);
    }
}

Console.WriteLine(classGen.GenerateCode());