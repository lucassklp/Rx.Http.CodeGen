using Newtonsoft.Json;

namespace Codacy.Models
{
    public class IgnoreSrmItemBody
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
