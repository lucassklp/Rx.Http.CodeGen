using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SlackIntegrationResponse
    {
        [JsonProperty("data")]
        public SlackIntegration Data { get; set; }
    }
}
