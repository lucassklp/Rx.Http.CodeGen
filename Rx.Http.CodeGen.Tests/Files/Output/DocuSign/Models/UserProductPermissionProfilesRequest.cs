using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UserProductPermissionProfilesRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("product_permission_profiles")]
        public List<ProductPermissionProfileRequest> ProductPermissionProfiles { get; set; }
    }
}
