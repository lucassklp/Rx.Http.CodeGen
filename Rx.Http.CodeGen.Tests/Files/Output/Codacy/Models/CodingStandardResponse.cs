using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandardResponse
    {
        [JsonProperty("data")]
        public CodingStandard Data { get; set; }
    }
}
