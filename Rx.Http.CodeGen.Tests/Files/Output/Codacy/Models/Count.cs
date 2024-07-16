using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Count
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
