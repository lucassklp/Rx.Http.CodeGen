namespace Codacy.Models
{
    public class CommitDeltaStatistics
    {
        public string CommitUuid { get; set; }
        public int NewIssues { get; set; }
        public int FixedIssues { get; set; }
        public int DeltaComplexity { get; set; }
        public int DeltaCoverage { get; set; }
        public double DeltaCoverageWithDecimals { get; set; }
        public int DeltaClonesCount { get; set; }
        public bool Analyzed { get; set; }
    }
}
