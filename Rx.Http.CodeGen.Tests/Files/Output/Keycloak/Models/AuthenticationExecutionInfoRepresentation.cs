using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class AuthenticationExecutionInfoRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("requirementChoices")]
        public List<string> RequirementChoices { get; set; }
        [JsonProperty("configurable")]
        public bool Configurable { get; set; }
        [JsonProperty("authenticationFlow")]
        public bool AuthenticationFlow { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("authenticationConfig")]
        public string AuthenticationConfig { get; set; }
        [JsonProperty("flowId")]
        public string FlowId { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("index")]
        public int Index { get; set; }
    }
}
