using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationBillingInformationResponse
    {
        [JsonProperty("data")]
        public OrganizationBillingInformation Data { get; set; }
    }
}
