using Newtonsoft.Json;

namespace Codacy.Models
{
    public class HealthCheckResponse
    {
        [JsonProperty("data")]
        public HealthCheck Data { get; set; }
    }
}
