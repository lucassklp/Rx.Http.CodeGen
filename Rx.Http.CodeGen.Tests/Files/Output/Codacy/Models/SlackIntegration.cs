using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SlackIntegration
    {
        [JsonProperty("organization_id")]
        public int OrganizationId { get; set; }
        [JsonProperty("webhook_url")]
        public string WebhookUrl { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
