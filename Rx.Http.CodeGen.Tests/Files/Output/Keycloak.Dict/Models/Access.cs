using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class Access
    {
        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
        [JsonProperty("verify_caller")]
        public bool VerifyCaller { get; set; }
    }
}
