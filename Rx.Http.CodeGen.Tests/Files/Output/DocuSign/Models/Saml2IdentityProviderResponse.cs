using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class Saml2IdentityProviderResponse
    {
        [JsonProperty("issuer")]
        public string Issuer { get; set; }
        [JsonProperty("settings")]
        public List<SettingResponse> Settings { get; set; }
        [JsonProperty("certificates")]
        public List<CertificateResponse> Certificates { get; set; }
        [JsonProperty("attribute_mappings")]
        public List<RequiredAttributeMappingResponse> AttributeMappings { get; set; }
    }
}
