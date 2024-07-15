using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryLanguage
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("codacyDefaults")]
        public List<string> CodacyDefaults { get; set; }
        [JsonProperty("extensions")]
        public List<string> Extensions { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("detected")]
        public bool Detected { get; set; }
    }
}
