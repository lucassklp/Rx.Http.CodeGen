using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class KeyStoreConfig
    {
        [JsonProperty("realmCertificate")]
        public bool RealmCertificate { get; set; }
        [JsonProperty("storePassword")]
        public string StorePassword { get; set; }
        [JsonProperty("keyPassword")]
        public string KeyPassword { get; set; }
        [JsonProperty("keyAlias")]
        public string KeyAlias { get; set; }
        [JsonProperty("realmAlias")]
        public string RealmAlias { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
    }
}
