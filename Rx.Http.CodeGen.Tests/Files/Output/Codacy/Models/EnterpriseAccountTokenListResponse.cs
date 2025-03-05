using Newtonsoft.Json;

namespace Codacy.Models
{
    public class EnterpriseAccountTokenListResponse
    {
        [JsonProperty("data")]
        public List<EnterpriseAccountToken> Data { get; set; }
    }
}
