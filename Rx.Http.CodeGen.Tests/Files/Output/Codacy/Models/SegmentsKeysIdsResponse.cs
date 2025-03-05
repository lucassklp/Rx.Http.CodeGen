using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SegmentsKeysIdsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<SegmentKeyWithId> Data { get; set; }
    }
}
