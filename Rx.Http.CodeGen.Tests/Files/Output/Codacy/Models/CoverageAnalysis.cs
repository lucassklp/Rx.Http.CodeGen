namespace Codacy.Models
{
    public class CoverageAnalysis
    {
        public double TotalCoveragePercentage { get; set; }
        public double DeltaCoveragePercentage { get; set; }
        public bool IsUpToStandards { get; set; }
        public List<AnalysisResultReason> ResultReasons { get; set; }
    }
}
