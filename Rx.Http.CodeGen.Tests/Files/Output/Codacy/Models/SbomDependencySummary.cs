using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SbomDependencySummary
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("repositoriesCount")]
        public int RepositoriesCount { get; set; }
        [JsonProperty("versionsCount")]
        public int VersionsCount { get; set; }
        [JsonProperty("findings")]
        public List<OpenFindingsCount> Findings { get; set; }
    }
}
