using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupAndUsersResponse
    {
        [JsonProperty("group")]
        public DsGroupResponse Group { get; set; }
        [JsonProperty("group_users")]
        public DsGroupUsersResponse GroupUsers { get; set; }
    }
}
