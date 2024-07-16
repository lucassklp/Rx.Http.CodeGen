using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class ClientPoliciesRepresentation
    {
        [JsonProperty("policies")]
        public List<ClientPolicyRepresentation> Policies { get; set; }
    }
}
