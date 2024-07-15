using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ApplyCodingStandardToRepositoriesResultResponse
    {
        [JsonProperty("data")]
        public ApplyCodingStandardToRepositoriesResult Data { get; set; }
    }
}
