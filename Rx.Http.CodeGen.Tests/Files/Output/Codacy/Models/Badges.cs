using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Badges
    {
        [JsonProperty("grade")]
        public string Grade { get; set; }
        [JsonProperty("coverage")]
        public string Coverage { get; set; }
    }
}
