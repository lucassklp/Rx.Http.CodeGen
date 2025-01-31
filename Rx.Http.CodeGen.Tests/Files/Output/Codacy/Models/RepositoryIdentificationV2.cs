using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryIdentificationV2
    {
        [JsonProperty("repositoryId")]
        public int RepositoryId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
    }
}
