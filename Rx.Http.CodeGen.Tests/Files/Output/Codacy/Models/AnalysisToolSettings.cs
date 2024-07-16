using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AnalysisToolSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
        [JsonProperty("hasConfigurationFile")]
        public bool HasConfigurationFile { get; set; }
        [JsonProperty("usesConfigurationFile")]
        public bool UsesConfigurationFile { get; set; }
    }
}
