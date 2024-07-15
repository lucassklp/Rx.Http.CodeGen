using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UserIdentityResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("immutable_id")]
        public string ImmutableId { get; set; }
        [JsonProperty("error_details")]
        public ErrorDetails ErrorDetails { get; set; }
    }
}
