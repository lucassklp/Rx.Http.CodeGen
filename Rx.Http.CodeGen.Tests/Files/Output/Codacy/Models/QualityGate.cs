namespace Codacy.Models
{
    public class QualityGate
    {
        public object IssueThreshold { get; set; }
        public int SecurityIssueThreshold { get; set; }
        public int DuplicationThreshold { get; set; }
        public int CoverageThreshold { get; set; }
        public double CoverageThresholdWithDecimals { get; set; }
        public int DiffCoverageThreshold { get; set; }
        public int ComplexityThreshold { get; set; }
    }
}
