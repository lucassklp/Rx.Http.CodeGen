using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfiguredPatternsListResponse
    {
        [JsonProperty("data")]
        public List<ConfiguredPattern> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("meta")]
        public ConfiguredPatternListMeta Meta { get; set; }
    }
}
