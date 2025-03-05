using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DastTarget
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
