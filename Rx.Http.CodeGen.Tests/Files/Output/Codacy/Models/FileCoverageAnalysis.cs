namespace Codacy.Models
{
    public class FileCoverageAnalysis
    {
        public double Coverage { get; set; }
        public int CoverableLines { get; set; }
        public int CoveredLines { get; set; }
    }
}
