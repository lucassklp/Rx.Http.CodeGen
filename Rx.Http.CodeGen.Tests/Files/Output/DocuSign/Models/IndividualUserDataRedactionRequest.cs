using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class IndividualUserDataRedactionRequest
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("memberships")]
        public List<MembershipDataRedactionRequest> Memberships { get; set; }
    }
}
