using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmDastReport
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("organizationId")]
        public int OrganizationId { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        [JsonProperty("generatedAt")]
        public string GeneratedAt { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("tool")]
        public string Tool { get; set; }
        [JsonProperty("failureReason")]
        public string FailureReason { get; set; }
    }
}
