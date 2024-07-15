using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ProblemLink
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
