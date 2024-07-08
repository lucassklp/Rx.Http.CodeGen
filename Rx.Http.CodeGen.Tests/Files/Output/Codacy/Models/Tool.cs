namespace Codacy.Models
{
    public class Tool
    {
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string ShortName { get; set; }
        public string DocumentationUrl { get; set; }
        public string SourceCodeUrl { get; set; }
        public string Prefix { get; set; }
        public bool NeedsCompilation { get; set; }
        public List<string> ConfigurationFilenames { get; set; }
        public string Description { get; set; }
        public string DockerImage { get; set; }
        public List<string> Languages { get; set; }
        public bool ClientSide { get; set; }
        public bool Standalone { get; set; }
        public bool EnabledByDefault { get; set; }
        public bool Configurable { get; set; }
    }
}
