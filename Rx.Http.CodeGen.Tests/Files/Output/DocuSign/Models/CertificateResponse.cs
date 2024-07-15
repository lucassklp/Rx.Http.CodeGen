using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class CertificateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("issuer")]
        public string Issuer { get; set; }
        [JsonProperty("thumbprint")]
        public string Thumbprint { get; set; }
        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }
        [JsonProperty("links")]
        public List<LinkResponse> Links { get; set; }
    }
}
