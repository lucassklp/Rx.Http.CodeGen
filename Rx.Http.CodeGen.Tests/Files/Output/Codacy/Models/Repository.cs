using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Repository
    {
        [JsonProperty("repositoryId")]
        public int RepositoryId { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("owner")]
        public string Owner { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("fullPath")]
        public string FullPath { get; set; }
        [JsonProperty("visibility")]
        public string Visibility { get; set; }
        [JsonProperty("remoteIdentifier")]
        public string RemoteIdentifier { get; set; }
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
        [JsonProperty("permission")]
        public string Permission { get; set; }
        [JsonProperty("problems")]
        public List<RepositoryProblem> Problems { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
        [JsonProperty("defaultBranch")]
        public Branch DefaultBranch { get; set; }
        [JsonProperty("badges")]
        public Badges Badges { get; set; }
        [JsonProperty("codingStandardId")]
        public int CodingStandardId { get; set; }
        [JsonProperty("codingStandardName")]
        public string CodingStandardName { get; set; }
        [JsonProperty("standards")]
        public List<CodingStandardInfo> Standards { get; set; }
        [JsonProperty("addedState")]
        public string AddedState { get; set; }
        [JsonProperty("gatePolicyId")]
        public int GatePolicyId { get; set; }
        [JsonProperty("gatePolicyName")]
        public string GatePolicyName { get; set; }
    }
}
