using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileCoverage
    {
        [JsonProperty("line")]
        public int Line { get; set; }
        [JsonProperty("hits")]
        public int Hits { get; set; }
    }
}
