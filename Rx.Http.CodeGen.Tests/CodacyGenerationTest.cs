namespace Rx.Http.CodeGen.Tests;

public class CodacyGenerationTests : FileGenerationTests
{
    private readonly ConsumerGenerationConfig consumerOptions;

    public CodacyGenerationTests()
    {
        consumerOptions = new ConsumerGenerationConfig
        {
            OpenApiDefinition = ReadInputFile("codacy.yaml"),
            Path = "",
            DocumentType = "yaml",
            ConsumerName = "Codacy",
            Type = "object",
            Namespace = "Codacy"
        };
    }

    [Fact]
    void TestCodacyConsumer()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        var generatedCode = consumerGen.ConsumerClassGen.GenerateCode().Replace("\r\n", "\n") + "\n";
        var expected = ReadOutputFile(consumerOptions.Namespace!, "CodacyConsumer.cs").Replace("\r\n", "\n");

        Assert.Equal(expected, generatedCode);
    }

    [Fact]
    void TestCodacyModels()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        consumerGen.ModelClassesGen.ForEach(modelClassGen => {
            var generatedCode = modelClassGen.GenerateCode().Replace("\r\n", "\n") + "\n";
            var expected = ReadModelFile(consumerOptions.Namespace!, $"{modelClassGen.ClassName}.cs").Replace("\r\n", "\n");

            Assert.Equal(expected, generatedCode);
        });
    }
}