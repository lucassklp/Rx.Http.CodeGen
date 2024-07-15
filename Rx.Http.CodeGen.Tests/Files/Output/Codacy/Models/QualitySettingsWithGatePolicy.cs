using Newtonsoft.Json;

namespace Codacy.Models
{
    public class QualitySettingsWithGatePolicy
    {
        [JsonProperty("qualityGate")]
        public QualityGate QualityGate { get; set; }
        [JsonProperty("repositoryGatePolicyInfo")]
        public RepositoryGatePolicy RepositoryGatePolicyInfo { get; set; }
    }
}
