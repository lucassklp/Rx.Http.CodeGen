using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OpenFindingsCount
    {
        [JsonProperty("severity")]
        public string Severity { get; set; }
        [JsonProperty("open")]
        public int Open { get; set; }
    }
}
