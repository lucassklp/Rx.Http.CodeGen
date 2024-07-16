using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitDeltaStatistics
    {
        [JsonProperty("commitUuid")]
        public string CommitUuid { get; set; }
        [JsonProperty("newIssues")]
        public int NewIssues { get; set; }
        [JsonProperty("fixedIssues")]
        public int FixedIssues { get; set; }
        [JsonProperty("deltaComplexity")]
        public int DeltaComplexity { get; set; }
        [JsonProperty("deltaCoverage")]
        public int DeltaCoverage { get; set; }
        [JsonProperty("deltaCoverageWithDecimals")]
        public double DeltaCoverageWithDecimals { get; set; }
        [JsonProperty("deltaClonesCount")]
        public int DeltaClonesCount { get; set; }
        [JsonProperty("analyzed")]
        public bool Analyzed { get; set; }
    }
}
