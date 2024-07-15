using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfigureToolBody
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("useConfigurationFile")]
        public bool UseConfigurationFile { get; set; }
        [JsonProperty("patterns")]
        public List<ConfigurePattern> Patterns { get; set; }
    }
}
