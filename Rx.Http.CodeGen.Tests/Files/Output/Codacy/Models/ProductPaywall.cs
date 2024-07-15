using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ProductPaywall
    {
        [JsonProperty("securityDashboard")]
        public bool SecurityDashboard { get; set; }
    }
}
