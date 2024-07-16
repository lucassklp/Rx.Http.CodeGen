using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationBillingPlan
    {
        [JsonProperty("isPremium")]
        public bool IsPremium { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
