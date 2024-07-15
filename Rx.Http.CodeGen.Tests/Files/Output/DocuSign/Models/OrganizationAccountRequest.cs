using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationAccountRequest
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }
}
