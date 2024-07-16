using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class IndividualUserDataRedactionResponse
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("membership_results")]
        public List<MembershipDataRedactionResponse> MembershipResults { get; set; }
    }
}
