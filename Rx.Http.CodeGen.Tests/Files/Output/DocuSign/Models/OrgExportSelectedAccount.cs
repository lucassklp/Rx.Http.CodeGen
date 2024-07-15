using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgExportSelectedAccount
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }
}
