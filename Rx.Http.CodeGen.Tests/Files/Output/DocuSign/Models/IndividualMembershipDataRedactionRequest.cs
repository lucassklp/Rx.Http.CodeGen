using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class IndividualMembershipDataRedactionRequest
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
