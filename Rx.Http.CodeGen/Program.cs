using Rx.Http.CodeGen;
using Rx.Http;
using System.Reactive.Linq;
using CommandLine;
using CaseConverter;

Parser.Default.ParseArguments<ConsumerGenerationOptions>(args)
    .WithParsed(options =>
    {
        Logger.IsVerbose = options.Verbose;

        string? openApiDefinition = null;
        var initialPath = Directory.GetCurrentDirectory();
        string defaultType = "object";
        if (!string.IsNullOrEmpty(options.Url))
        {
            Logger.Log($"Fetching {options.Url}");
            try
            {
                var httpClient = RxHttpClient.Create();
                openApiDefinition = httpClient.Get(options.Url)
                    .SelectMany(httpResp => httpResp.Content.ReadAsStringAsync())
                    .Wait();
            }
            catch (Exception ex)
            {
                Logger.Log($"An error occurred when fetching {options.Url}: {ex.Message}", ConsoleColor.Red);
                Logger.LogVerbose(ex.StackTrace, ConsoleColor.Red);
                return;
            }
        }
        else if (!string.IsNullOrEmpty(options.File))
        {
            try
            {
                Logger.Log($"Reading {options.File}");
                if (options.File?.StartsWith(".") ?? false)
                {
                    openApiDefinition = File.ReadAllText(Path.Combine(initialPath, options.File));
                }
                else
                {
                    openApiDefinition = File.ReadAllText(options.File!);
                }
            }
            catch (Exception ex) 
            {
                Logger.Log($"An error occurred when reading {options.File}: {ex.Message}", ConsoleColor.Red);
                Logger.LogVerbose(ex.StackTrace, ConsoleColor.Red);
                return;
            }
        }

        if(options.Type == "dictionary")
        {
            defaultType = "IDictionary<string, object>";
        }

        if (!string.IsNullOrEmpty(openApiDefinition))
        {
            Logger.Log($"Trying to generate the code");
            Logger.LogVerbose($"OpenApi definition read: {openApiDefinition}");

            try
            {
                var consumerConfig = new ConsumerGenerationConfig
                {
                    Path = Path.Combine(initialPath, options.Namespace!),
                    Namespace = options.Namespace,
                    OpenApiDefinition = openApiDefinition,
                    ConsumerName = options.Output?.ToPascalCase() ?? "",
                    Type = defaultType,
                    Verbose = options.Verbose
                };

                var consumerGen = new ConsumerGenerator(consumerConfig);
                consumerGen.GenerateFiles();

                Logger.Log("Code generated successfully!", ConsoleColor.Green);
                return;
            }
            catch (Exception ex)
            {
                Logger.Log($"An error occurred when generating files: {ex.Message}", ConsoleColor.Red);
                Logger.LogVerbose(ex.StackTrace, ConsoleColor.Red);
                return;
            }
        }
    });