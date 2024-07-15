using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmItemResponse
    {
        [JsonProperty("data")]
        public SrmItem Data { get; set; }
    }
}
