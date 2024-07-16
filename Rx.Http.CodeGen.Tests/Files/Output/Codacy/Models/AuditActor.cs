using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AuditActor
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
