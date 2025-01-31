using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Seat
    {
        [JsonProperty("organizationsIds")]
        public List<int> OrganizationsIds { get; set; }
        [JsonProperty("emails")]
        public List<string> Emails { get; set; }
        [JsonProperty("lastAnalysis")]
        public string LastAnalysis { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("lastCommitId")]
        public int LastCommitId { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("providerLogin")]
        public string ProviderLogin { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }
}
