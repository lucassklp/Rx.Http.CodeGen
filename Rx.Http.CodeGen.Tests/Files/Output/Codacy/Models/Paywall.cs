using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Paywall
    {
        [JsonProperty("organizationDashboard")]
        public bool OrganizationDashboard { get; set; }
        [JsonProperty("securityDashboard")]
        public bool SecurityDashboard { get; set; }
    }
}
