using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Version
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
