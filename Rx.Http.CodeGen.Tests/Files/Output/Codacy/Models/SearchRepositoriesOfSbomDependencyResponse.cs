using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchRepositoriesOfSbomDependencyResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<RepositorySummaryOfSbomDependency> Data { get; set; }
        [JsonProperty("overview")]
        public RepositoriesOverviewOfSbomDependency Overview { get; set; }
    }
}
