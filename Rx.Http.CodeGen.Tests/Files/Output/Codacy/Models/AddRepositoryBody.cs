using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AddRepositoryBody
    {
        [JsonProperty("repositoryFullPath")]
        public string RepositoryFullPath { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
    }
}
