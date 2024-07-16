using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestWithAnalysis
    {
        [JsonProperty("isUpToStandards")]
        public bool IsUpToStandards { get; set; }
        [JsonProperty("isAnalysing")]
        public bool IsAnalysing { get; set; }
        [JsonProperty("pullRequest")]
        public PullRequest PullRequest { get; set; }
        [JsonProperty("newIssues")]
        public int NewIssues { get; set; }
        [JsonProperty("fixedIssues")]
        public int FixedIssues { get; set; }
        [JsonProperty("deltaComplexity")]
        public int DeltaComplexity { get; set; }
        [JsonProperty("deltaClonesCount")]
        public int DeltaClonesCount { get; set; }
        [JsonProperty("deltaCoverageWithDecimals")]
        public double DeltaCoverageWithDecimals { get; set; }
        [JsonProperty("deltaCoverage")]
        public int DeltaCoverage { get; set; }
        [JsonProperty("diffCoverage")]
        public double DiffCoverage { get; set; }
        [JsonProperty("coverage")]
        public PullRequestCoverage Coverage { get; set; }
        [JsonProperty("quality")]
        public QualityAnalysis Quality { get; set; }
        [JsonProperty("meta")]
        public AnalysisMeta Meta { get; set; }
    }
}
