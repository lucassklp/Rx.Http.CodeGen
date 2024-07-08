namespace Codacy.Models
{
    public class QualityAnalysis
    {
        public int NewIssues { get; set; }
        public int FixedIssues { get; set; }
        public int DeltaComplexity { get; set; }
        public int DeltaClonesCount { get; set; }
        public bool IsUpToStandards { get; set; }
        public List<AnalysisResultReason> ResultReasons { get; set; }
    }
}
