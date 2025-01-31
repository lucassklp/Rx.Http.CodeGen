using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchSbomDependenciesResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<SbomDependencySummary> Data { get; set; }
        [JsonProperty("overview")]
        public SbomDependenciesOverview Overview { get; set; }
    }
}
