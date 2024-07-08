namespace Codacy.Models
{
    public class FileDiffCoverage
    {
        public string FileName { get; set; }
        public double Coverage { get; set; }
        public double Variation { get; set; }
        public DiffCoverage Diff { get; set; }
        public List<DiffLineHit> DiffLineHits { get; set; }
    }
}
