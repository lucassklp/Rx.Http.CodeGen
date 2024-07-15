using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("identities")]
        public List<UserIdentityResponse> Identities { get; set; }
    }
}
