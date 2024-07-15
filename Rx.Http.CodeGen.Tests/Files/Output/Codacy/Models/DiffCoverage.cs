using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DiffCoverage
    {
        [JsonProperty("value")]
        public double Value { get; set; }
        [JsonProperty("coveredLines")]
        public int CoveredLines { get; set; }
        [JsonProperty("coverableLines")]
        public int CoverableLines { get; set; }
        [JsonProperty("cause")]
        public string Cause { get; set; }
    }
}
