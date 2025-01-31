using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoriesOverviewOfSbomDependency
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("latestVersion")]
        public string LatestVersion { get; set; }
        [JsonProperty("oldestVersion")]
        public string OldestVersion { get; set; }
        [JsonProperty("totalVersionsCount")]
        public int TotalVersionsCount { get; set; }
        [JsonProperty("filteredVersionsCount")]
        public int FilteredVersionsCount { get; set; }
        [JsonProperty("totalRepositoriesCount")]
        public int TotalRepositoriesCount { get; set; }
        [JsonProperty("filteredRepositoriesCount")]
        public int FilteredRepositoriesCount { get; set; }
    }
}
