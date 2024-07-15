using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfiguredPattern
    {
        [JsonProperty("patternDefinition")]
        public Pattern PatternDefinition { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("parameters")]
        public List<ConfiguredParameter> Parameters { get; set; }
    }
}
