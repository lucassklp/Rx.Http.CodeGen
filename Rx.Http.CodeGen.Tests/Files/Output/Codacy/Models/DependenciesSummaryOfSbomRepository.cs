using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DependenciesSummaryOfSbomRepository
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("dependenciesCount")]
        public int DependenciesCount { get; set; }
        [JsonProperty("dependenciesFindings")]
        public List<OpenFindingsCount> DependenciesFindings { get; set; }
    }
}
