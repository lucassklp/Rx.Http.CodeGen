using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryIdentification
    {
        [JsonProperty("repositoryId")]
        public int RepositoryId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
