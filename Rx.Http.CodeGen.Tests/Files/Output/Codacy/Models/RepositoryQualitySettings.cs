namespace Codacy.Models
{
    public class RepositoryQualitySettings
    {
        public int MaxIssuePercentage { get; set; }
        public int MaxDuplicatedFilesPercentage { get; set; }
        public int MinCoveragePercentage { get; set; }
        public int MaxComplexFilesPercentage { get; set; }
        public int FileDuplicationBlockThreshold { get; set; }
        public int FileComplexityValueThreshold { get; set; }
    }
}
