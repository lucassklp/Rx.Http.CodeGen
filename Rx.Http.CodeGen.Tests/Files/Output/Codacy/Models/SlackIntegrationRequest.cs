using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SlackIntegrationRequest
    {
        [JsonProperty("webhook_url")]
        public string WebhookUrl { get; set; }
    }
}
