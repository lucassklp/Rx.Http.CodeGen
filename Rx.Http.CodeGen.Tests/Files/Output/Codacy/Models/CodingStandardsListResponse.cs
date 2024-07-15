using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandardsListResponse
    {
        [JsonProperty("data")]
        public List<CodingStandard> Data { get; set; }
    }
}
