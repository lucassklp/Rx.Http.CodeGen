using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestFilesCoverageResponse
    {
        [JsonProperty("data")]
        public List<FileDiffCoverage> Data { get; set; }
    }
}
