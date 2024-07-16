using Newtonsoft.Json;

namespace Codacy.Models
{
    public class JiraIntegration
    {
        [JsonProperty("organization_id")]
        public int OrganizationId { get; set; }
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }
        [JsonProperty("instance_name")]
        public string InstanceName { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
