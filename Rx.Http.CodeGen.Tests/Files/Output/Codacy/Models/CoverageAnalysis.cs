using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CoverageAnalysis
    {
        [JsonProperty("totalCoveragePercentage")]
        public double TotalCoveragePercentage { get; set; }
        [JsonProperty("deltaCoveragePercentage")]
        public double DeltaCoveragePercentage { get; set; }
        [JsonProperty("isUpToStandards")]
        public bool IsUpToStandards { get; set; }
        [JsonProperty("resultReasons")]
        public List<AnalysisResultReason> ResultReasons { get; set; }
    }
}
