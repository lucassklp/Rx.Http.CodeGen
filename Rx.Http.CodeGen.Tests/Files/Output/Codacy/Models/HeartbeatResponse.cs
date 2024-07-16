using Newtonsoft.Json;

namespace Codacy.Models
{
    public class HeartbeatResponse
    {
        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }
        [JsonProperty("idleExpiresIn")]
        public int IdleExpiresIn { get; set; }
        [JsonProperty("absoluteExpiresIn")]
        public int AbsoluteExpiresIn { get; set; }
    }
}
