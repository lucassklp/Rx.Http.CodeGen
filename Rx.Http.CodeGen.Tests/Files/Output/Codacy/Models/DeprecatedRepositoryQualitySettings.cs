using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DeprecatedRepositoryQualitySettings
    {
        [JsonProperty("issueThreshold")]
        public int IssueThreshold { get; set; }
        [JsonProperty("duplicationThreshold")]
        public int DuplicationThreshold { get; set; }
        [JsonProperty("coverageThreshold")]
        public int CoverageThreshold { get; set; }
        [JsonProperty("complexityThreshold")]
        public int ComplexityThreshold { get; set; }
        [JsonProperty("fileDuplicationThreshold")]
        public int FileDuplicationThreshold { get; set; }
        [JsonProperty("fileComplexityThreshold")]
        public int FileComplexityThreshold { get; set; }
    }
}
