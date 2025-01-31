using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DependenciesOverviewOfSbomRepositories
    {
        [JsonProperty("totalRepositoriesCount")]
        public int TotalRepositoriesCount { get; set; }
        [JsonProperty("filteredRepositoriesCount")]
        public int FilteredRepositoriesCount { get; set; }
        [JsonProperty("totalDependenciesCount")]
        public int TotalDependenciesCount { get; set; }
        [JsonProperty("filteredDependenciesCount")]
        public int FilteredDependenciesCount { get; set; }
    }
}
