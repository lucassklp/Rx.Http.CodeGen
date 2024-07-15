using Newtonsoft.Json;

namespace Codacy.Models
{
    public class HeartbeatRequest
    {
        [JsonProperty("wasActive")]
        public bool WasActive { get; set; }
    }
}
