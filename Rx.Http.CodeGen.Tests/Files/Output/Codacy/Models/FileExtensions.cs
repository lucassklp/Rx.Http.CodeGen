using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileExtensions
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("codacyDefaults")]
        public List<string> CodacyDefaults { get; set; }
        [JsonProperty("extensions")]
        public List<string> Extensions { get; set; }
    }
}
