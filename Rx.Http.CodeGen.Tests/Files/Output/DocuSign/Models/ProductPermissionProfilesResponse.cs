using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class ProductPermissionProfilesResponse
    {
        [JsonProperty("product_permission_profiles")]
        public List<ProductPermissionProfileResponse> ProductPermissionProfiles { get; set; }
    }
}
