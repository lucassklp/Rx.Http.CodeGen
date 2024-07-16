using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Integration
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("lastAuthenticated")]
        public string LastAuthenticated { get; set; }
    }
}
