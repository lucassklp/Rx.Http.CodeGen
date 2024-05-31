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
foreach (var schema in openApiDocument.Components.Schemas)
{
    var modelClassGen = new ClassGen(name: schema.Key.ToPascalCase())
        .Namespace(@namespace)
        .Public();

    var properties = schema.Value.Properties;

    foreach (var property in properties)
    {
        var type = typesMap[property.Value.Type];

        var fieldGen = new FieldGen(name: property.Key.ToPascalCase(), type: type)
            .Public();

        modelClassGen.WithField(fieldGen);
    }

    Console.WriteLine(modelClassGen.GenerateCode());
}


//Generate the consumer
var classGen = new ClassGen("OpenApiPetStoreConsumer")
    .Extends("RxHttpClient")
    .Namespace(@namespace)
    .Using("Rx.Http", "Rx.Http.Extensions");

foreach(var path in openApiDocument.Paths)
{
    foreach(var operation in path.Value.Operations)
    {
        OpenApiSchema schema = null;
        try
        {
            schema = operation.Value.Responses["200"]?.Content["application/json"]?.Schema;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"failed to {path.Key} {operation.Key}. {ex.Message}");
        }

        string type = schema?.Reference?.Id ?? "void";

        if(schema?.Type == "array")
        {
            type = $"List<{schema.Items.Reference.Id}>";
        }

        var body = string.Empty;

        var methodGen = new MethodGen(name: operation.Value.OperationId.ToPascalCase(), returnType: $"Observable<{type}>")
            .Public();
            
        if (operation.Value.RequestBody is null)
        {
            body = $"""
                return {operation.Key.GetDisplayName().ToPascalCase()}<{type}>($"{path.Key}");
                """;
        }
        else
        {
            var bodyType = "object";

            if (operation.Value.RequestBody.Content.Any(x => x.Key == "application/json"))
            {
                bodyType = typesMap[operation.Value.RequestBody.Content["application/json"].Schema.Type];
            }
            
            methodGen.WithParameter(bodyType, "body");
            body = $"""
                return {operation.Key.GetDisplayName().ToPascalCase()}<{type}>($"{path.Key}", body);
                """;
        }

        methodGen.WithBody(body);

        foreach (var parameter in operation.Value.Parameters)
        {
            var name = parameter.Name;
            var paramType = typesMap[parameter.Schema.Type];
            methodGen.WithParameter(name: name, type: paramType);
                
        }
        classGen.WithMethod(methodGen);
    }
}

Console.WriteLine(classGen.GenerateCode());

Console.ReadKey();