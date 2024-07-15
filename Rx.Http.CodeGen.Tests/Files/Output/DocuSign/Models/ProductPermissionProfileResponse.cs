using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class ProductPermissionProfileResponse
    {
        [JsonProperty("product_id")]
        public string ProductId { get; set; }
        [JsonProperty("product_name")]
        public string ProductName { get; set; }
        [JsonProperty("permission_profiles")]
        public List<PermissionProfileResponse21> PermissionProfiles { get; set; }
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}
