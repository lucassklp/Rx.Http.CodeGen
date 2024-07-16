using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DiffLineHit
    {
        [JsonProperty("lineNumber")]
        public string LineNumber { get; set; }
        [JsonProperty("hits")]
        public int Hits { get; set; }
    }
}
