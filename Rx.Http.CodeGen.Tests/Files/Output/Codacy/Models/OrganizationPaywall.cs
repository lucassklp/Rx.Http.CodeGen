using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationPaywall
    {
        [JsonProperty("organizationDashboard")]
        public bool OrganizationDashboard { get; set; }
    }
}
