namespace Codacy.Models
{
    public class DiffCoverage
    {
        public double Value { get; set; }
        public int CoveredLines { get; set; }
        public int CoverableLines { get; set; }
        public string Cause { get; set; }
    }
}
