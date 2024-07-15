using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestWithCoverage
    {
        [JsonProperty("pullRequest")]
        public PullRequest PullRequest { get; set; }
        [JsonProperty("coverage")]
        public PullRequestCoverage Coverage { get; set; }
    }
}
