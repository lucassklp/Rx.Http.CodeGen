using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileCoverageAnalysis
    {
        [JsonProperty("coverage")]
        public double Coverage { get; set; }
        [JsonProperty("coverableLines")]
        public int CoverableLines { get; set; }
        [JsonProperty("coveredLines")]
        public int CoveredLines { get; set; }
    }
}
