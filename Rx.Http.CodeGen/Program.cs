using Rx.Http.CodeGen;
using Rx.Http;
using System.Reactive.Linq;
using CommandLine;
using CaseConverter;


Parser.Default.ParseArguments<ConsumerGenerationOptions>(args)
    .WithParsed(options =>
    {

        Console.ResetColor();

        string? openApiDefinition = null;
        var initialPath = Directory.GetCurrentDirectory();
        string defaultType = "object";
        if (!string.IsNullOrEmpty(options.Url))
        {
            Console.WriteLine($"Fetching {options.Url}");
            try
            {
                var httpClient = RxHttpClient.Create();
                openApiDefinition = httpClient.Get(options.Url)
                    .SelectMany(httpResp => httpResp.Content.ReadAsStringAsync())
                    .Wait();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred when fetching {options.Url}: {ex.Message}");
                Console.ResetColor();
                return;
            }
        }
        else if (!string.IsNullOrEmpty(options.File))
        {
            try
            {
                Console.WriteLine($"Reading {options.File}");
                if (options.File?.StartsWith(".") ?? false)
                {
                    openApiDefinition = File.ReadAllText(Path.Combine(initialPath, options.File));
                }
                else
                {
                    openApiDefinition = File.ReadAllText(options.File);
                }
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred when reading {options.File}: {ex.Message}");
                Console.ResetColor();
                return;
            }
        }

        if(options.Type == "dictionary")
        {
            defaultType = "IDictionary<string, object>";
        }

        if (!string.IsNullOrEmpty(openApiDefinition))
        {
            Console.WriteLine($"Trying to generate the code");
            if (options.Verbose)
            {
                Console.WriteLine($"OpenApi definition read: {openApiDefinition}");
            }
            try
            {
                var consumerConfig = new ConsumerGenerationConfig
                {
                    Path = Path.Combine(initialPath, options.Namespace),
                    Namespace = options.Namespace,
                    OpenApiDefinition = openApiDefinition,
                    ConsumerName = options.Output?.ToPascalCase() ?? "",
                    Type = defaultType
                };

                var consumerGen = new ConsumerGenerator(consumerConfig);
                consumerGen.GenerateFiles();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Code generated successfully!");
                Console.ResetColor();
                return;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred when generating files: {ex.Message}");
                Console.ResetColor();
                return;
            }
        }
    });