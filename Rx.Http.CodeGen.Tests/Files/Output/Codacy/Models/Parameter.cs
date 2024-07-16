using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Parameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("default")]
        public string Default { get; set; }
    }
}
