using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DomainResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("host_name")]
        public string HostName { get; set; }
        [JsonProperty("txt_token")]
        public string TxtToken { get; set; }
        [JsonProperty("identity_provider_id")]
        public string IdentityProviderId { get; set; }
        [JsonProperty("settings")]
        public List<SettingResponse> Settings { get; set; }
        [JsonProperty("links")]
        public List<LinkResponse> Links { get; set; }
    }
}
