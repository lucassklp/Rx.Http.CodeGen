namespace Rx.Http.CodeGen
{
    public class ConsumerGenerationConfig
    {
        public required string OpenApiDefinition { get; init; }

        public required string DocumentType { get; init; }
        
        public required string Path { get; init; }

        public required string Namespace { get; init; }

        public required string ConsumerName { get; init; }

        public required string Type { get; init; }
    }
}
