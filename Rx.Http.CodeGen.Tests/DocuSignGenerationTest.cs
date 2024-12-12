namespace Rx.Http.CodeGen.Tests;

public class DocuSignGenerationTests : FileGenerationTests
{
    private readonly ConsumerGenerationConfig consumerOptions;

    public DocuSignGenerationTests()
    {
        consumerOptions = new ConsumerGenerationConfig
        {
            OpenApiDefinition = ReadInputFile("docusign.json"),
            Path = "",
            DocumentType = "json",
            ConsumerName = "DocuSign",
            Type = "object",
            Namespace = "DocuSign"
        };
    }

    [Fact]
    void TestDocuSignConsumer()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        var generatedCode = consumerGen.ConsumerClassGen.GenerateCode().Replace("\r\n", "\n") + "\n";
        var expected = ReadOutputFile(consumerOptions.Namespace!, "DocuSignConsumer.cs").Replace("\r\n", "\n");

        Assert.Equal(expected, generatedCode);
    }

    [Fact]
    void TestDocuSignModels()
    {
        var consumerGen = new ConsumerGenerator(consumerOptions);

        consumerGen.ModelClassesGen.ForEach(modelClassGen => {
            var generatedCode = modelClassGen.GenerateCode().Replace("\r\n", "\n") + "\n";
            var expected = ReadModelFile(consumerOptions.Namespace!, $"{modelClassGen.ClassName}.cs").Replace("\r\n", "\n");

            Assert.Equal(expected, generatedCode);
        });
    }

}