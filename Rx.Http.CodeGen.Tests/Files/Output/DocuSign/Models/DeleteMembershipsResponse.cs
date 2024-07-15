using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DeleteMembershipsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("accounts")]
        public List<DeleteMembershipResponse> Accounts { get; set; }
    }
}
