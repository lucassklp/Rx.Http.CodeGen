using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GatePolicySummarized
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
        [JsonProperty("meta")]
        public GatePolicyMeta Meta { get; set; }
    }
}
