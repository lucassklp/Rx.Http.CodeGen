using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class CertificateRepresentation
    {
        [JsonProperty("privateKey")]
        public string PrivateKey { get; set; }
        [JsonProperty("publicKey")]
        public string PublicKey { get; set; }
        [JsonProperty("certificate")]
        public string Certificate { get; set; }
        [JsonProperty("kid")]
        public string Kid { get; set; }
    }
}
