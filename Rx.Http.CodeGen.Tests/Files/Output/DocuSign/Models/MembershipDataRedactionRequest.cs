using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class MembershipDataRedactionRequest
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }
}
