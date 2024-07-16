using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryLanguageUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("extensions")]
        public List<string> Extensions { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
