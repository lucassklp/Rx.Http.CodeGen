using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class ProductPermissionProfileRequest
    {
        [JsonProperty("product_id")]
        public string ProductId { get; set; }
        [JsonProperty("permission_profile_id")]
        public string PermissionProfileId { get; set; }
    }
}
