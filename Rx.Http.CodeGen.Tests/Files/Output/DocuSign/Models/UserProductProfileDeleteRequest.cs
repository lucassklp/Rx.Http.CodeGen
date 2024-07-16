using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UserProductProfileDeleteRequest
    {
        [JsonProperty("user_email")]
        public string UserEmail { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("product_ids")]
        public List<string> ProductIds { get; set; }
    }
}
