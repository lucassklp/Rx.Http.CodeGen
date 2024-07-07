namespace Codacy.Models
{
    public class AnalysisResultReason
    {
        public string Gate { get; set; }
        public double Expected { get; set; }
        public AnalysisExpectedThreshold ExpectedThreshold { get; set; }
        public bool IsUpToStandards { get; set; }
    }
}
