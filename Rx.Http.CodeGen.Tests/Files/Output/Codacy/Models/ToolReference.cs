using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ToolReference
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
