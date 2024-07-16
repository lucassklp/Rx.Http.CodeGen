using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AnalysisExpectedThreshold
    {
        [JsonProperty("threshold")]
        public double Threshold { get; set; }
        [JsonProperty("minimumSeverity")]
        public string MinimumSeverity { get; set; }
    }
}
