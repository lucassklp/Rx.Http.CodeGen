using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AnalysisMeta
    {
        [JsonProperty("analyzable")]
        public bool Analyzable { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
