using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandard
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isDraft")]
        public bool IsDraft { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
        [JsonProperty("meta")]
        public CodingStandardMeta Meta { get; set; }
    }
}
