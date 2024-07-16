using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationAccountsRequest
    {
        [JsonProperty("accounts")]
        public List<OrganizationAccountRequest> Accounts { get; set; }
    }
}
