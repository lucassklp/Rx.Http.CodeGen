using Newtonsoft.Json;

namespace Codacy.Models
{
    public class JiraIntegrationResponse
    {
        [JsonProperty("data")]
        public JiraIntegration Data { get; set; }
    }
}
