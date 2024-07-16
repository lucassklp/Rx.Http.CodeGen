using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class MembershipDataRedactionResponse
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
