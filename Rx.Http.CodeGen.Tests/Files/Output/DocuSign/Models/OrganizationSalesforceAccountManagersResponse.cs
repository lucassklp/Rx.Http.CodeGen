using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationSalesforceAccountManagersResponse
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("account_type")]
        public string AccountType { get; set; }
        [JsonProperty("account_owner")]
        public OsamrContact AccountOwner { get; set; }
        [JsonProperty("account_manager")]
        public OsamrContact AccountManager { get; set; }
        [JsonProperty("parent_account")]
        public OrganizationSalesforceAccountManagersResponse ParentAccount { get; set; }
    }
}
