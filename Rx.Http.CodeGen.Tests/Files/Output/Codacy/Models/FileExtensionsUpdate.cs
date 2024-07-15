using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileExtensionsUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("extensions")]
        public List<string> Extensions { get; set; }
    }
}
