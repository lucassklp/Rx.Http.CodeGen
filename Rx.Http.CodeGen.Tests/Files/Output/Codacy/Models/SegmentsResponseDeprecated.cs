using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SegmentsResponseDeprecated
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<SegmentEntryDeprecated> Data { get; set; }
    }
}
