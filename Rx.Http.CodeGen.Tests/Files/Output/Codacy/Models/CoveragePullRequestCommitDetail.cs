using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CoveragePullRequestCommitDetail
    {
        [JsonProperty("commitId")]
        public int CommitId { get; set; }
        [JsonProperty("commitSha")]
        public string CommitSha { get; set; }
        [JsonProperty("reports")]
        public List<PullRequestCoverageReport> Reports { get; set; }
    }
}
