using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositorySummaryOfSbomDependency
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("dependencyVersion")]
        public string DependencyVersion { get; set; }
        [JsonProperty("highestFindingSeverity")]
        public string HighestFindingSeverity { get; set; }
        [JsonProperty("licenses")]
        public List<string> Licenses { get; set; }
    }
}
