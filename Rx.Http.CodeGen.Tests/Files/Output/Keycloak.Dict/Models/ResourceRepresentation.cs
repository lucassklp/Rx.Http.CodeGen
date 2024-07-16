using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class ResourceRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("uris")]
        public List<string> Uris { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("scopes")]
        public List<ScopeRepresentation> Scopes { get; set; }
        [JsonProperty("icon_uri")]
        public string IconUri { get; set; }
        [JsonProperty("owner")]
        public ResourceRepresentationOwner Owner { get; set; }
        [JsonProperty("ownerManagedAccess")]
        public bool OwnerManagedAccess { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("attributes")]
        public Dictionary<string, object> Attributes { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonProperty("scopesUma")]
        public List<ScopeRepresentation> ScopesUma { get; set; }
    }
}
