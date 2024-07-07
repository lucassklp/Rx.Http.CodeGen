namespace Codacy.Models
{
    public class DeprecatedRepositoryQualitySettings
    {
        public int IssueThreshold { get; set; }
        public int DuplicationThreshold { get; set; }
        public int CoverageThreshold { get; set; }
        public int ComplexityThreshold { get; set; }
        public int FileDuplicationThreshold { get; set; }
        public int FileComplexityThreshold { get; set; }
    }
}
