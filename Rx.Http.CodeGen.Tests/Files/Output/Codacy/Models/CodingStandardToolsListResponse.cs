using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandardToolsListResponse
    {
        [JsonProperty("data")]
        public List<CodingStandardTool> Data { get; set; }
    }
}
