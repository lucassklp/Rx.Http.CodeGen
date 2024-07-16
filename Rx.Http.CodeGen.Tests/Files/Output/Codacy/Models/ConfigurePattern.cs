using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfigurePattern
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("parameters")]
        public List<ConfiguredParameter> Parameters { get; set; }
    }
}
