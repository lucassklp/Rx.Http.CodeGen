using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AnalysisResultReason
    {
        [JsonProperty("gate")]
        public string Gate { get; set; }
        [JsonProperty("expected")]
        public double Expected { get; set; }
        [JsonProperty("expectedThreshold")]
        public AnalysisExpectedThreshold ExpectedThreshold { get; set; }
        [JsonProperty("isUpToStandards")]
        public bool IsUpToStandards { get; set; }
    }
}
