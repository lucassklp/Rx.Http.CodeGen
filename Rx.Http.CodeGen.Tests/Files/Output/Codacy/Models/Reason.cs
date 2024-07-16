using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Reason
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("notes")]
        public List<string> Notes { get; set; }
    }
}
