using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DuplicationToolListResponse
    {
        [JsonProperty("data")]
        public List<DuplicationTool> Data { get; set; }
    }
}
