using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AddDsGroupAndUsersResponse
    {
        [JsonProperty("group")]
        public DsGroupResponse Group { get; set; }
        [JsonProperty("group_users")]
        public AddDsGroupUsersResponse GroupUsers { get; set; }
    }
}
