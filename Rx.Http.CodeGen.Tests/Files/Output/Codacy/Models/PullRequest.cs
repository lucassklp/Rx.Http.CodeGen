using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("updated")]
        public string Updated { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("repository")]
        public string Repository { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("owner")]
        public PullRequestOwner Owner { get; set; }
        [JsonProperty("headCommitSha")]
        public string HeadCommitSha { get; set; }
        [JsonProperty("commonAncestorCommitSha")]
        public string CommonAncestorCommitSha { get; set; }
        [JsonProperty("originBranch")]
        public string OriginBranch { get; set; }
        [JsonProperty("targetBranch")]
        public string TargetBranch { get; set; }
        [JsonProperty("gitHref")]
        public string GitHref { get; set; }
    }
}
