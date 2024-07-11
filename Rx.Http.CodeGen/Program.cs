using Rx.Http.CodeGen;
using System.Reactive.Linq;
using CommandLine;

Parser.Default.ParseArguments<ConsumerGenerationArgs>(args)
    .WithParsed(options =>
    {
        Logger.IsVerbose = options.Verbose;
        var configuratorProcessor = new ConfigurationProcessor(options);
        try
        {
            var config = configuratorProcessor.Process();
            var consumerGenerator = new ConsumerGenerator(config);
            consumerGenerator.GenerateFiles();
        }
        catch (Exception ex)
        {
            Logger.Log(ex.Message, ConsoleColor.Red);
            Logger.LogVerbose(ex.StackTrace, ConsoleColor.Red);
        }
    });

