using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Person
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("emails")]
        public List<string> Emails { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("committerId")]
        public int CommitterId { get; set; }
        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }
        [JsonProperty("lastAnalysis")]
        public string LastAnalysis { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        [JsonProperty("canBeRemoved")]
        public bool CanBeRemoved { get; set; }
        [JsonProperty("lastCommitId")]
        public int LastCommitId { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("providerLogin")]
        public string ProviderLogin { get; set; }
        [JsonProperty("isProviderRegistered")]
        public bool IsProviderRegistered { get; set; }
    }
}
