using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DeleteMembershipsRequest
    {
        [JsonProperty("accounts")]
        public List<DeleteMembershipRequest> Accounts { get; set; }
    }
}
