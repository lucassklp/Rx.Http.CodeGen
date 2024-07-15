using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class RemoveUserProductsResponse
    {
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
        [JsonProperty("user_email")]
        public string UserEmail { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("user_product_results")]
        public object UserProductResults { get; set; }
    }
}
