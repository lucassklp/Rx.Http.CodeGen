using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestWithCoverageResponse
    {
        [JsonProperty("data")]
        public PullRequestWithCoverage Data { get; set; }
    }
}
