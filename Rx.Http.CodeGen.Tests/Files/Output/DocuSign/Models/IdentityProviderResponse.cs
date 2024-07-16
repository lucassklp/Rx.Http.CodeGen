using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class IdentityProviderResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }
        [JsonProperty("auto_provision_users")]
        public bool AutoProvisionUsers { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("saml_20")]
        public Saml2IdentityProviderResponse Saml20 { get; set; }
        [JsonProperty("links")]
        public List<LinkResponse> Links { get; set; }
    }
}
