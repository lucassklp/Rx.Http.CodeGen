using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchSbomRepositoriesResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<DependenciesSummaryOfSbomRepository> Data { get; set; }
        [JsonProperty("overview")]
        public DependenciesOverviewOfSbomRepositories Overview { get; set; }
    }
}
