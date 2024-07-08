namespace Codacy.Models
{
    public class Coverage
    {
        public int FilesUncovered { get; set; }
        public int FilesWithLowCoverage { get; set; }
        public int CoveragePercentage { get; set; }
        public double CoveragePercentageWithDecimals { get; set; }
        public int NumberTotalFiles { get; set; }
        public int NumberCoveredLines { get; set; }
        public int NumberCoverableLines { get; set; }
    }
}
