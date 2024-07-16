using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositorySummary
    {
        [JsonProperty("repositoryId")]
        public int RepositoryId { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("owner")]
        public string Owner { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
