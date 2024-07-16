using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationWithMeta
    {
        [JsonProperty("organization")]
        public Organization Organization { get; set; }
        [JsonProperty("membership")]
        public Membership Membership { get; set; }
        [JsonProperty("billing")]
        public Billing Billing { get; set; }
        [JsonProperty("paywall")]
        public Paywall Paywall { get; set; }
        [JsonProperty("organizationPayWall")]
        public OrganizationPaywall OrganizationPayWall { get; set; }
        [JsonProperty("analysisConfigurationMinimumPermission")]
        public string AnalysisConfigurationMinimumPermission { get; set; }
        [JsonProperty("subscriptions")]
        public List<ProductSubscription> Subscriptions { get; set; }
    }
}
