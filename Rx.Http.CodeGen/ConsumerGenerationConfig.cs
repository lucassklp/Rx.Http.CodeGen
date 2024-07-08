namespace Rx.Http.CodeGen
{
    public class ConsumerGenerationConfig
    {
        public required string OpenApiDefinition { get; init; }
        
        public required string Path { get; init; }

        public string? Namespace { get; init; }

        public required string ConsumerName { get; init; }

        public required string Type { get; init; }

        public required bool Verbose { get; init; }
    }
}
