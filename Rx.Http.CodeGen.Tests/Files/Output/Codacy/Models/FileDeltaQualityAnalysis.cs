namespace Codacy.Models
{
    public class FileDeltaQualityAnalysis
    {
        public int DeltaNewIssues { get; set; }
        public int DeltaFixedIssues { get; set; }
        public int DeltaComplexity { get; set; }
        public int DeltaClonesCount { get; set; }
    }
}
