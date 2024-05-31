// See https://aka.ms/new-console-template for more information
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Fluent.CodeGen;
using CaseConverter;
using Microsoft.OpenApi.Expressions;
using Microsoft.OpenApi.Models;


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


//Generate model classes (schemas)
ClassGen GenerateModelClasses(string name, OpenApiSchema schema)
{
    var modelClassGen = new ClassGen(name: name.ToPascalCase())
        .Namespace(@namespace)
        .Public();

    var properties = schema.Properties;

    foreach (var property in properties)
    {
        var type = typesMap[property.Value.Type];

        if(type == "object")
        {
            type = property.Value.Reference.Id;
        }
        else if(type == "List<object>")
        {
            var subtype = property.Value?.Items?.Reference?.Id ?? property.Value?.Items?.Type;
            type = $"List<{subtype}>";
        }

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

    string type = schema?.Reference?.Id ?? "object";

    if(schema?.Type == "array")
    {
        type = $"List<{schema.Items.Reference.Id}>";
    }

    var body = string.Empty;

    var methodGen = new MethodGen(name: operation.OperationId.ToPascalCase(), returnType: $"IObservable<{type}>")
        .Public();
        
    if (operation.RequestBody is null)
    {
        body = $"""
            return {httpMethod.ToPascalCase()}<{type}>($"{path}");
            """;
    }
    else
    {
        var bodyType = "object";

        if (operation.RequestBody.Content.Any(x => x.Key == "application/json"))
        {
            bodyType = typesMap[operation.RequestBody.Content["application/json"].Schema.Type];
        }
        
        methodGen.WithParameter(bodyType, "body");
        body = $"""
            return {httpMethod.ToPascalCase()}<{type}>($"{path}", body);
            """;
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