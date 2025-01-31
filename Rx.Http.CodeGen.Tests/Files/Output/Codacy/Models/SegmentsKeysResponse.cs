using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SegmentsKeysResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<string> Data { get; set; }
    }
}
