namespace Rx.Http.CodeGen.Tests;

public class KeycloakDictGenerationTests : FileGenerationTests
{
    private readonly ConsumerGenerationConfig consumerOptions;

    public KeycloakDictGenerationTests()
    {
        consumerOptions = new ConsumerGenerationConfig
        {
            OpenApiDefinition = ReadInputFile("keycloak.json"),
            Path = "",
            DocumentType = "json",
            ConsumerName = "Keycloak",
            Type = "Dictionary<string, object>",
            Namespace = "Keycloak.Dict"
        };
    }

    [Fact]
    void TestKeycloakConsumer()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        var generatedCode = consumerGen.ConsumerClassGen.GenerateCode().Replace("\r\n", "\n") + "\n";
        var expected = ReadOutputFile(consumerOptions.Namespace!, "KeycloakConsumer.cs").Replace("\r\n", "\n");

        Assert.Equal(expected, generatedCode);
    }

    [Fact]
    void TestKeycloakTokenInterceptor()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        var generatedCode = consumerGen.TokenInterceptorClassGen!.GenerateCode().Replace("\r\n", "\n") + "\n";
        var expected = ReadOutputFile(consumerOptions.Namespace!, "KeycloakTokenInterceptor.cs").Replace("\r\n", "\n");

        Assert.Equal(expected, generatedCode);
    }


    [Fact]
    void TestKeycloakModels()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        consumerGen.ModelClassesGen.ForEach(modelClassGen => {
            var generatedCode = modelClassGen.GenerateCode().Replace("\r\n", "\n") + "\n";
            var expected = ReadModelFile(consumerOptions.Namespace!, $"{modelClassGen.ClassName}.cs").Replace("\r\n", "\n");

            Assert.Equal(expected, generatedCode);
        });
    }

}