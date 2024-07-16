using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryQualitySettings
    {
        [JsonProperty("maxIssuePercentage")]
        public int MaxIssuePercentage { get; set; }
        [JsonProperty("maxDuplicatedFilesPercentage")]
        public int MaxDuplicatedFilesPercentage { get; set; }
        [JsonProperty("minCoveragePercentage")]
        public int MinCoveragePercentage { get; set; }
        [JsonProperty("maxComplexFilesPercentage")]
        public int MaxComplexFilesPercentage { get; set; }
        [JsonProperty("fileDuplicationBlockThreshold")]
        public int FileDuplicationBlockThreshold { get; set; }
        [JsonProperty("fileComplexityValueThreshold")]
        public int FileComplexityValueThreshold { get; set; }
    }
}
