namespace Rx.Http.CodeGen.Tests;

public class CodacyGenerationTests : FileGenerationTests
{
    private string definitionFile;
    private ConsumerGenerationConfig consumerOptions;

    public CodacyGenerationTests()
    {
        definitionFile = ReadInputFile("codacy.yaml");
        consumerOptions = new ConsumerGenerationConfig
        {
            OpenApiDefinition = definitionFile,
            Path = "",
            ConsumerName = "Codacy",
            Type = "object",
            Namespace = "Codacy",
            Verbose = false
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