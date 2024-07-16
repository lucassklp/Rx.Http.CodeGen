using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class RemoveDsGroupUsersResponse
    {
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
        [JsonProperty("failed_users")]
        public List<DsGroupUserResponse> FailedUsers { get; set; }
    }
}
