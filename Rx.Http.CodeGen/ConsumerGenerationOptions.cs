using CommandLine;

namespace Rx.Http.CodeGen
{
    internal class ConsumerGenerationOptions
    {
        [Option('f', "file", Required = false, HelpText = "Set the OpenApi definition file location")]
        public string File { get; set; }

        [Option('u', "url", Required = false, HelpText = "Set the OpenApi definition url location")]
        public string Url { get; set; }

        [Option('n', "namespace", Required = true, HelpText = "The name of the namespace of generated source")]
        public string Namespace { get; set; }

        [Option('o', "output", Required = true, HelpText = "The output consumer class name")]
        public string Output { get; set; }

        [Option('t', "type", Required = false, Default = "object", HelpText = "Set the default type for unknown models. Possible values: 'object' or 'dictionary'")]
        public string Type { get; set; }

        [Option('v', "verbose", Required = false, Default = false, HelpText = "Define if debug logs will appear")]
        public bool Verbose { get; set; }

    }
}
