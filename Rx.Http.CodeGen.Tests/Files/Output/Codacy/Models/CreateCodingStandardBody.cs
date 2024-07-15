using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CreateCodingStandardBody
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
    }
}
