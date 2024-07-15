using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfigurationStatus
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
