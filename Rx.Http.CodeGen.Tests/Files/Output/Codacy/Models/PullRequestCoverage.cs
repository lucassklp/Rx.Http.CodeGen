using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestCoverage
    {
        [JsonProperty("deltaCoverage")]
        public double DeltaCoverage { get; set; }
        [JsonProperty("diffCoverage")]
        public DiffCoverage DiffCoverage { get; set; }
        [JsonProperty("isUpToStandards")]
        public bool IsUpToStandards { get; set; }
        [JsonProperty("resultReasons")]
        public List<AnalysisResultReason> ResultReasons { get; set; }
    }
}
