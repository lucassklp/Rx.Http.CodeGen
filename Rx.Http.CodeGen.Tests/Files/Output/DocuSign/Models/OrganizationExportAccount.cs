using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationExportAccount
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }
}
