using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class ProductPermissionProfilesRequest
    {
        [JsonProperty("product_permission_profiles")]
        public List<ProductPermissionProfileRequest> ProductPermissionProfiles { get; set; }
    }
}
