using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ProductSubscription
    {
        [JsonProperty("product")]
        public string Product { get; set; }
        [JsonProperty("plan")]
        public OrganizationBillingPlan Plan { get; set; }
        [JsonProperty("paywall")]
        public ProductPaywall Paywall { get; set; }
    }
}
