using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SegmentsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<SegmentEntry> Data { get; set; }
    }
}
