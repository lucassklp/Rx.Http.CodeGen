using Newtonsoft.Json;

namespace Codacy.Models
{
    public class BranchRequiredChecks
    {
        [JsonProperty("quality")]
        public bool Quality { get; set; }
        [JsonProperty("diffCoverage")]
        public bool DiffCoverage { get; set; }
        [JsonProperty("coverageVariation")]
        public bool CoverageVariation { get; set; }
    }
}
