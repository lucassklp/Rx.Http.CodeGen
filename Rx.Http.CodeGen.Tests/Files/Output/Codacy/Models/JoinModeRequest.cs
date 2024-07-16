using Newtonsoft.Json;

namespace Codacy.Models
{
    public class JoinModeRequest
    {
        [JsonProperty("joinMode")]
        public string JoinMode { get; set; }
    }
}
