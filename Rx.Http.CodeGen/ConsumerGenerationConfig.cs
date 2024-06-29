namespace Rx.Http.CodeGen
{
    public class ConsumerGenerationConfig
    {
        public string? OpenApiDefinition { get; set; }
        
        public string? Path { get; set; }

        public string? Namespace { get; set; }

        public string? ConsumerName { get; set; }

        public string? Type { get; set; }

        public bool Verbose { get; set; }
    }
}
