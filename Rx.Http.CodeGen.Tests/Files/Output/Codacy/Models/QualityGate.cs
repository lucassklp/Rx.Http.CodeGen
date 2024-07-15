using Newtonsoft.Json;

namespace Codacy.Models
{
    public class QualityGate
    {
        [JsonProperty("issueThreshold")]
        public object IssueThreshold { get; set; }
        [JsonProperty("securityIssueThreshold")]
        public int SecurityIssueThreshold { get; set; }
        [JsonProperty("duplicationThreshold")]
        public int DuplicationThreshold { get; set; }
        [JsonProperty("coverageThreshold")]
        public int CoverageThreshold { get; set; }
        [JsonProperty("coverageThresholdWithDecimals")]
        public double CoverageThresholdWithDecimals { get; set; }
        [JsonProperty("diffCoverageThreshold")]
        public int DiffCoverageThreshold { get; set; }
        [JsonProperty("complexityThreshold")]
        public int ComplexityThreshold { get; set; }
    }
}
