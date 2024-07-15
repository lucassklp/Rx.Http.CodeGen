using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AddedStateResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
