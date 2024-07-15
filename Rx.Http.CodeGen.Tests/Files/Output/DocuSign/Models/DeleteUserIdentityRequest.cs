using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DeleteUserIdentityRequest
    {
        [JsonProperty("identities")]
        public List<UserIdentityRequest> Identities { get; set; }
    }
}
