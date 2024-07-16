using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GatePolicyMeta
    {
        [JsonProperty("nrOfQualityGates")]
        public int NrOfQualityGates { get; set; }
        [JsonProperty("linkedRepositoriesCount")]
        public int LinkedRepositoriesCount { get; set; }
    }
}
