using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AddDsGroupUsersResponse
    {
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
        [JsonProperty("TotalCount")]
        public int TotalCount { get; set; }
        [JsonProperty("users")]
        public List<DsGroupUserResponse> Users { get; set; }
    }
}
