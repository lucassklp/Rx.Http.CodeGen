using Newtonsoft.Json;

namespace Codacy.Models
{
    public class HealthCheck
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
