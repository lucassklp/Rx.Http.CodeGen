using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UsersUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("users")]
        public List<UserUpdateResponse> Users { get; set; }
    }
}
