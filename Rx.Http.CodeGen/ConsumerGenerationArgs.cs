using CommandLine;

namespace Rx.Http.CodeGen
{
    public class ConsumerGenerationArgs
    {
        [Option('f', "file", Required = false, HelpText = "Set the OpenApi definition file location")]
        public string? File { get; set; }

        [Option('u', "url", Required = false, HelpText = "Set the OpenApi definition url location")]
        public string? Url { get; set; }

        [Option('d', "document type", Required = false, HelpText = "Force to use a document type. Possible values: 'json' or 'yaml'. default: Extension from url or file. If undefined, json by default.")]
        public string? DocumentType { get; set; }

        [Option('n', "namespace", Required = true, HelpText = "The name of the namespace of generated source")]
        public required string Namespace { get; set; }

        [Option('o', "output", Required = true, HelpText = "The output Consumer Class Name")]
        public required string Output { get; set; }

        [Option('t', "type", Required = false, Default = "object", HelpText = "Set the default type for unknown models. Possible values: 'object' or 'dictionary'")]
        public string? Type { get; set; }

        [Option('v', "verbose", Required = false, Default = false, HelpText = "Define if debug logs will appear")]
        public bool Verbose { get; set; }
    }
}
