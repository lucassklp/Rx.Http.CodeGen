using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GetGatePolicyResultResponse
    {
        [JsonProperty("data")]
        public GatePolicy Data { get; set; }
    }
}
