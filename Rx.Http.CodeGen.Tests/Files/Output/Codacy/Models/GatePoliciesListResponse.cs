using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GatePoliciesListResponse
    {
        [JsonProperty("data")]
        public List<GatePolicySummarized> Data { get; set; }
    }
}
