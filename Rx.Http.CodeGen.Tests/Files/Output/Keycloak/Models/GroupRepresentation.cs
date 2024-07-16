using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class GroupRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("attributes")]
        public object Attributes { get; set; }
        [JsonProperty("realmRoles")]
        public List<string> RealmRoles { get; set; }
        [JsonProperty("clientRoles")]
        public object ClientRoles { get; set; }
        [JsonProperty("subGroups")]
        public List<GroupRepresentation> SubGroups { get; set; }
        [JsonProperty("access")]
        public object Access { get; set; }
    }
}
