namespace Rx.Http.CodeGen.Tests;

public class ConfigurationProcessorTests : FileGenerationTests
{

    [Fact]
    void TestConfigurationProcessorFileAndTypeDictionary()
    {
        var args = new ConsumerGenerationArgs()
        {
            File = Path.Combine(Directory.GetCurrentDirectory(), "Files", "Inputs", "keycloak.json"),
            Namespace = "Test.Namespace",
            Output = "Test",
            Type = "dictionary"
        };

        var configurationProcessor = new ConfigurationProcessor(args);
        var consumerConfig = configurationProcessor.Process();

        Assert.Equal(ReadInputFile("keycloak.json"), consumerConfig.OpenApiDefinition);
        Assert.Equal(args.Namespace, consumerConfig.Namespace);
        Assert.Equal("Test", consumerConfig.ConsumerName);
        Assert.Equal("Dictionary<string, object>", consumerConfig.Type);
    }

    [Fact]
    void TestConfigurationProcessorWithoutOpenApiDefinition()
    {
        var args = new ConsumerGenerationArgs()
        {
            Namespace = "Test.Namespace",
            Output = "Test"
        };

        var configurationProcessor = new ConfigurationProcessor(args);

        Assert.Throws<Exception>(() => configurationProcessor.Process());
    }

    [Fact]
    void TestConfigurationProcessorTypeObject()
    {
        var args = new ConsumerGenerationArgs()
        {
            File = Path.Combine(Directory.GetCurrentDirectory(), "Files", "Inputs", "keycloak.json"),
            Namespace = "Test.Namespace",
            Output = "Test",
            Type = "object",
        };

        var configurationProcessor = new ConfigurationProcessor(args);
        var consumerConfig = configurationProcessor.Process();

        Assert.Equal(ReadInputFile("keycloak.json"), consumerConfig.OpenApiDefinition);
        Assert.Equal(args.Namespace, consumerConfig.Namespace);
        Assert.Equal("Test", consumerConfig.ConsumerName);
        Assert.Equal("object", consumerConfig.Type);
    }

}