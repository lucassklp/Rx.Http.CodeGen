using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class Permission
    {
        [JsonProperty("rsid")]
        public string Rsid { get; set; }
        [JsonProperty("rsname")]
        public string Rsname { get; set; }
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }
        [JsonProperty("claims")]
        public Dictionary<string, object> Claims { get; set; }
    }
}
