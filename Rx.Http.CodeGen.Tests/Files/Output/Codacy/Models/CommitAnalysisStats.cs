using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitAnalysisStats
    {
        [JsonProperty("repositoryId")]
        public int RepositoryId { get; set; }
        [JsonProperty("commitId")]
        public int CommitId { get; set; }
        [JsonProperty("numberIssues")]
        public int NumberIssues { get; set; }
        [JsonProperty("numberLoc")]
        public int NumberLoc { get; set; }
        [JsonProperty("issuesPerCategory")]
        public List<CategoryIssues> IssuesPerCategory { get; set; }
        [JsonProperty("issuePercentage")]
        public int IssuePercentage { get; set; }
        [JsonProperty("totalComplexity")]
        public int TotalComplexity { get; set; }
        [JsonProperty("numberComplexFiles")]
        public int NumberComplexFiles { get; set; }
        [JsonProperty("complexFilesPercentage")]
        public int ComplexFilesPercentage { get; set; }
        [JsonProperty("filesChangedToIncreaseComplexity")]
        public int FilesChangedToIncreaseComplexity { get; set; }
        [JsonProperty("numberDuplicatedLines")]
        public int NumberDuplicatedLines { get; set; }
        [JsonProperty("duplicationPercentage")]
        public int DuplicationPercentage { get; set; }
        [JsonProperty("coveragePercentage")]
        public int CoveragePercentage { get; set; }
        [JsonProperty("coveragePercentageWithDecimals")]
        public double CoveragePercentageWithDecimals { get; set; }
        [JsonProperty("numberFilesUncovered")]
        public int NumberFilesUncovered { get; set; }
        [JsonProperty("techDebt")]
        public int TechDebt { get; set; }
        [JsonProperty("totalFilesAdded")]
        public int TotalFilesAdded { get; set; }
        [JsonProperty("totalFilesRemoved")]
        public int TotalFilesRemoved { get; set; }
        [JsonProperty("totalFilesChanged")]
        public int TotalFilesChanged { get; set; }
        [JsonProperty("commitTimestamp")]
        public string CommitTimestamp { get; set; }
        [JsonProperty("commitAuthorName")]
        public string CommitAuthorName { get; set; }
        [JsonProperty("commitShortUUID")]
        public string CommitShortUuid { get; set; }
    }
}
