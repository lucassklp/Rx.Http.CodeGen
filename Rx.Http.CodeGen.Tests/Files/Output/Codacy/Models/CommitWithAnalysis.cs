namespace Codacy.Models
{
    public class CommitWithAnalysis
    {
        public Commit Commit { get; set; }
        public CoverageAnalysis Coverage { get; set; }
        public QualityAnalysis Quality { get; set; }
        public AnalysisMeta Meta { get; set; }
    }
}
