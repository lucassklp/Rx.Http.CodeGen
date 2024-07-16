using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CheckSubmodulesResponse
    {
        [JsonProperty("data")]
        public bool Data { get; set; }
    }
}
