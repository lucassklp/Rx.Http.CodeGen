using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfiguredPatternResponse
    {
        [JsonProperty("data")]
        public ConfiguredPattern Data { get; set; }
    }
}
