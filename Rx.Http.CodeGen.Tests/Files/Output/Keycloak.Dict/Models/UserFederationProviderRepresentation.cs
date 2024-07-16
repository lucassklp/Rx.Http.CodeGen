using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class UserFederationProviderRepresentation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }
        [JsonProperty("config")]
        public Dictionary<string, object> Config { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("fullSyncPeriod")]
        public int FullSyncPeriod { get; set; }
        [JsonProperty("changedSyncPeriod")]
        public int ChangedSyncPeriod { get; set; }
        [JsonProperty("lastSync")]
        public int LastSync { get; set; }
    }
}
