using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UserProductPermissionProfilesResponse
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("product_permission_profiles")]
        public List<ProductPermissionProfileResponse> ProductPermissionProfiles { get; set; }
    }
}
