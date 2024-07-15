using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ToolConfiguration
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("patterns")]
        public List<PatternConfiguration> Patterns { get; set; }
    }
}
