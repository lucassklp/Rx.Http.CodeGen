using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PatternListResponse
    {
        [JsonProperty("data")]
        public List<Pattern> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
