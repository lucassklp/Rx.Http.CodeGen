namespace Codacy.Models
{
    public class PullRequestCoverage
    {
        public double DeltaCoverage { get; set; }
        public DiffCoverage DiffCoverage { get; set; }
        public bool IsUpToStandards { get; set; }
        public List<AnalysisResultReason> ResultReasons { get; set; }
    }
}
