using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryWithAnalysis
    {
        [JsonProperty("lastAnalysedCommit")]
        public Commit LastAnalysedCommit { get; set; }
        [JsonProperty("grade")]
        public int Grade { get; set; }
        [JsonProperty("gradeLetter")]
        public string GradeLetter { get; set; }
        [JsonProperty("issuesPercentage")]
        public int IssuesPercentage { get; set; }
        [JsonProperty("issuesCount")]
        public int IssuesCount { get; set; }
        [JsonProperty("loc")]
        public int Loc { get; set; }
        [JsonProperty("complexFilesPercentage")]
        public int ComplexFilesPercentage { get; set; }
        [JsonProperty("complexFilesCount")]
        public int ComplexFilesCount { get; set; }
        [JsonProperty("duplicationPercentage")]
        public int DuplicationPercentage { get; set; }
        [JsonProperty("repository")]
        public Repository Repository { get; set; }
        [JsonProperty("branch")]
        public Branch Branch { get; set; }
        [JsonProperty("selectedBranch")]
        public Branch SelectedBranch { get; set; }
        [JsonProperty("coverage")]
        public Coverage Coverage { get; set; }
        [JsonProperty("goals")]
        public RepositoryQualitySettings Goals { get; set; }
    }
}
