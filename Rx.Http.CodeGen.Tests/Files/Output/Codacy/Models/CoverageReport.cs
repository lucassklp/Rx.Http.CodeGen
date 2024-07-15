using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CoverageReport
    {
        [JsonProperty("targetCommitSha")]
        public string TargetCommitSha { get; set; }
        [JsonProperty("commit")]
        public CommitWithBranches Commit { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
