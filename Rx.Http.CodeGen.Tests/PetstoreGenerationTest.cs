namespace Rx.Http.CodeGen.Tests;

public class PetstoreGenerationTests : FileGenerationTests
{
    private string definitionFile;
    private ConsumerGenerationConfig consumerOptions;

    public PetstoreGenerationTests()
    {
        definitionFile = ReadInputFile("petstore.json");
        consumerOptions = new ConsumerGenerationConfig
        {
            OpenApiDefinition = definitionFile,
            Path = "",
            ConsumerName = "Petstore",
            Type = "object",
            Namespace = "Swagger.Petstore",
            Verbose = false
        };
    }

    [Fact]
    void TestPetstoreConsumer()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        var generatedCode = consumerGen.ConsumerClassGen.GenerateCode().Replace("\r\n", "\n");
        var expected = ReadOutputFile(consumerOptions.Namespace!, "PetstoreConsumer.cs").Replace("\r\n", "\n");

        Assert.Equal(expected, generatedCode);
    }

    [Fact]
    void TestPetstoreModels()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        consumerGen.ModelClassesGen.ForEach(modelClassGen => {
            var generatedCode = modelClassGen.GenerateCode().Replace("\r\n", "\n");
            var expected = ReadModelFile(consumerOptions.Namespace!, $"{modelClassGen.ClassName}.cs").Replace("\r\n", "\n");

            Assert.Equal(expected, generatedCode);
        });
    }

}