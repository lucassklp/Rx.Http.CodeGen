using Newtonsoft.Json;

namespace Codacy.Models
{
    public class QualityAnalysis
    {
        [JsonProperty("newIssues")]
        public int NewIssues { get; set; }
        [JsonProperty("fixedIssues")]
        public int FixedIssues { get; set; }
        [JsonProperty("deltaComplexity")]
        public int DeltaComplexity { get; set; }
        [JsonProperty("deltaClonesCount")]
        public int DeltaClonesCount { get; set; }
        [JsonProperty("isUpToStandards")]
        public bool IsUpToStandards { get; set; }
        [JsonProperty("resultReasons")]
        public List<AnalysisResultReason> ResultReasons { get; set; }
    }
}
