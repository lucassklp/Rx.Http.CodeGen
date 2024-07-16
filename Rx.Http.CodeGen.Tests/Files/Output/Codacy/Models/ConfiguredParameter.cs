using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfiguredParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
