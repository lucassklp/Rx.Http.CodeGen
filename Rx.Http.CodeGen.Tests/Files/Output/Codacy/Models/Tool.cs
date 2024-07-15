using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Tool
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("documentationUrl")]
        public string DocumentationUrl { get; set; }
        [JsonProperty("sourceCodeUrl")]
        public string SourceCodeUrl { get; set; }
        [JsonProperty("prefix")]
        public string Prefix { get; set; }
        [JsonProperty("needsCompilation")]
        public bool NeedsCompilation { get; set; }
        [JsonProperty("configurationFilenames")]
        public List<string> ConfigurationFilenames { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("dockerImage")]
        public string DockerImage { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
        [JsonProperty("clientSide")]
        public bool ClientSide { get; set; }
        [JsonProperty("standalone")]
        public bool Standalone { get; set; }
        [JsonProperty("enabledByDefault")]
        public bool EnabledByDefault { get; set; }
        [JsonProperty("configurable")]
        public bool Configurable { get; set; }
    }
}
