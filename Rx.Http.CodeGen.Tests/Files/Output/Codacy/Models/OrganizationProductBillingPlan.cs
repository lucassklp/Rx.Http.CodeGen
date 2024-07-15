using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationProductBillingPlan
    {
        [JsonProperty("product")]
        public string Product { get; set; }
        [JsonProperty("plan")]
        public Billing Plan { get; set; }
    }
}
