using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Coverage
    {
        [JsonProperty("filesUncovered")]
        public int FilesUncovered { get; set; }
        [JsonProperty("filesWithLowCoverage")]
        public int FilesWithLowCoverage { get; set; }
        [JsonProperty("coveragePercentage")]
        public int CoveragePercentage { get; set; }
        [JsonProperty("coveragePercentageWithDecimals")]
        public double CoveragePercentageWithDecimals { get; set; }
        [JsonProperty("numberTotalFiles")]
        public int NumberTotalFiles { get; set; }
        [JsonProperty("numberCoveredLines")]
        public int NumberCoveredLines { get; set; }
        [JsonProperty("numberCoverableLines")]
        public int NumberCoverableLines { get; set; }
    }
}
