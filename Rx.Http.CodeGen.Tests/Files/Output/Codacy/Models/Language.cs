using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Language
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
