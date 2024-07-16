using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Branch
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
        [JsonProperty("branchType")]
        public string BranchType { get; set; }
        [JsonProperty("lastCommit")]
        public string LastCommit { get; set; }
    }
}
