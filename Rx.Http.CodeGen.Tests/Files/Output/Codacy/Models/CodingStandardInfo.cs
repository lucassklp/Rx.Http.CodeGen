using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandardInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
