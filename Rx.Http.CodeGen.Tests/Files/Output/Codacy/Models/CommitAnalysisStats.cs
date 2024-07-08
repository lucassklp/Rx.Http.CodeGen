namespace Codacy.Models
{
    public class CommitAnalysisStats
    {
        public int RepositoryId { get; set; }
        public int CommitId { get; set; }
        public int NumberIssues { get; set; }
        public int NumberLoc { get; set; }
        public List<CategoryIssues> IssuesPerCategory { get; set; }
        public int IssuePercentage { get; set; }
        public int TotalComplexity { get; set; }
        public int NumberComplexFiles { get; set; }
        public int ComplexFilesPercentage { get; set; }
        public int FilesChangedToIncreaseComplexity { get; set; }
        public int NumberDuplicatedLines { get; set; }
        public int DuplicationPercentage { get; set; }
        public int CoveragePercentage { get; set; }
        public double CoveragePercentageWithDecimals { get; set; }
        public int NumberFilesUncovered { get; set; }
        public int TechDebt { get; set; }
        public int TotalFilesAdded { get; set; }
        public int TotalFilesRemoved { get; set; }
        public int TotalFilesChanged { get; set; }
        public string CommitTimestamp { get; set; }
        public string CommitAuthorName { get; set; }
        public string CommitShortUuid { get; set; }
    }
}
