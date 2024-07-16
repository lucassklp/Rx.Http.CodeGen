using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class IdentityProvidersResponse
    {
        [JsonProperty("identity_providers")]
        public List<IdentityProviderResponse> IdentityProviders { get; set; }
    }
}
