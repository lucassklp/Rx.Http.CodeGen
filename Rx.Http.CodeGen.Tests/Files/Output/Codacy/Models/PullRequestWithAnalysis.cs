namespace Codacy.Models
{
    public class PullRequestWithAnalysis
    {
        public bool IsUpToStandards { get; set; }
        public bool IsAnalysing { get; set; }
        public PullRequest PullRequest { get; set; }
        public int NewIssues { get; set; }
        public int FixedIssues { get; set; }
        public int DeltaComplexity { get; set; }
        public int DeltaClonesCount { get; set; }
        public double DeltaCoverageWithDecimals { get; set; }
        public int DeltaCoverage { get; set; }
        public double DiffCoverage { get; set; }
        public PullRequestCoverage Coverage { get; set; }
        public QualityAnalysis Quality { get; set; }
        public AnalysisMeta Meta { get; set; }
    }
}
