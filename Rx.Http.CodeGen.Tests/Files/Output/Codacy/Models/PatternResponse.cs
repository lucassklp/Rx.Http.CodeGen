using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PatternResponse
    {
        [JsonProperty("data")]
        public Pattern Data { get; set; }
    }
}
