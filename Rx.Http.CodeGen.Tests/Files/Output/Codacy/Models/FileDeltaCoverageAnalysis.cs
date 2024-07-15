using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileDeltaCoverageAnalysis
    {
        [JsonProperty("deltaCoverage")]
        public double DeltaCoverage { get; set; }
        [JsonProperty("totalCoverage")]
        public double TotalCoverage { get; set; }
    }
}
