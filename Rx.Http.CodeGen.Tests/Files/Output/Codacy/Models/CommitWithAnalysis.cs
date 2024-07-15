using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitWithAnalysis
    {
        [JsonProperty("commit")]
        public Commit Commit { get; set; }
        [JsonProperty("coverage")]
        public CoverageAnalysis Coverage { get; set; }
        [JsonProperty("quality")]
        public QualityAnalysis Quality { get; set; }
        [JsonProperty("meta")]
        public AnalysisMeta Meta { get; set; }
    }
}
