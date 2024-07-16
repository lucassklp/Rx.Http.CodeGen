using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class PathCacheConfig
    {
        [JsonProperty("max-entries")]
        public int MaxEntries { get; set; }
        [JsonProperty("lifespan")]
        public int Lifespan { get; set; }
    }
}
