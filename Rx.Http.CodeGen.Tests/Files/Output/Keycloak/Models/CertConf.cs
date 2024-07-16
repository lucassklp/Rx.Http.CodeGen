using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class CertConf
    {
        [JsonProperty("x5t#S256")]
        public string X5tS256 { get; set; }
    }
}
