using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationUserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("user_status")]
        public string UserStatus { get; set; }
        [JsonProperty("membership_status")]
        public string MembershipStatus { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
        [JsonProperty("membership_created_on")]
        public string MembershipCreatedOn { get; set; }
        [JsonProperty("ds_groups")]
        public List<DsGroupResponse> DsGroups { get; set; }
        [JsonProperty("membership_id")]
        public string MembershipId { get; set; }
    }
}
