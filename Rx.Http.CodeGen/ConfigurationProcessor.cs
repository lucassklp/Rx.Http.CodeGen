using System.Reactive.Linq;
using CaseConverter;
using Rx.Http;
using Rx.Http.CodeGen;

public class ConfigurationProcessor(ConsumerGenerationArgs args)
{
    public ConsumerGenerationConfig Process()
    {        
        string? openApiDefinition = null;
        var initialPath = Directory.GetCurrentDirectory();
        string defaultType = "object";
        string documentType = "json";

        if (!string.IsNullOrEmpty(args.Url))
        {
            documentType = ReadDocumentType(args, args.Url);
            Logger.Log($"Fetching {args.Url}");
            try
            {
                var httpClient = RxHttpClient.Create();
                openApiDefinition = httpClient.Get(args.Url)
                    .SelectMany(httpResp => httpResp.Content.ReadAsStringAsync())
                    .Wait();
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred when fetching {args.Url}: {ex.Message}", ex);
            }
        }
        else if (!string.IsNullOrEmpty(args.File))
        {
            documentType = ReadDocumentType(args, args.File);

            try
            {
                Logger.Log($"Reading {args.File}");
                if (args.File?.StartsWith(".") ?? false)
                {
                    openApiDefinition = File.ReadAllText(Path.Combine(initialPath, args.File));
                }
                else
                {
                    openApiDefinition = File.ReadAllText(args.File!);
                }
            }
            catch (Exception ex) 
            {
                string message = $"An error occurred when reading {args.File}: {ex.Message}";
                throw new Exception(message, ex);
            }
        }
        else 
        {
            throw new Exception("You need to give a File or Url of a valid OpenApi Definition");
        }

        if(args.Type == "dictionary")
        {
            defaultType = "Dictionary<string, object>";
        }

        return new ConsumerGenerationConfig
        {
            Path = Path.Combine(initialPath, args.Namespace),
            Namespace = args.Namespace,
            OpenApiDefinition = openApiDefinition!,
            DocumentType = documentType,
            ConsumerName = args.Output.ToPascalCase(),
            Type = defaultType,
        };
    }

    private string ReadDocumentType(ConsumerGenerationArgs args, string pathOrUrl)
    {
        if(args.DocumentType is string type)
        {
            return type;
        }

        if(pathOrUrl.EndsWith("json")){
            return "json";
        }

        if(pathOrUrl.EndsWith("yaml")){
            return "yaml";
        }

        return "json";
    }
}