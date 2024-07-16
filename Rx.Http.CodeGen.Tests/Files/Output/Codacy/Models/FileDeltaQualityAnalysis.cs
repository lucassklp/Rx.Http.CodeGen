using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileDeltaQualityAnalysis
    {
        [JsonProperty("deltaNewIssues")]
        public int DeltaNewIssues { get; set; }
        [JsonProperty("deltaFixedIssues")]
        public int DeltaFixedIssues { get; set; }
        [JsonProperty("deltaComplexity")]
        public int DeltaComplexity { get; set; }
        [JsonProperty("deltaClonesCount")]
        public int DeltaClonesCount { get; set; }
    }
}
