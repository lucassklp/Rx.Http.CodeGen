using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Organization
    {
        [JsonProperty("identifier")]
        public int Identifier { get; set; }
        [JsonProperty("remoteIdentifier")]
        public string RemoteIdentifier { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("joinMode")]
        public string JoinMode { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("joinStatus")]
        public string JoinStatus { get; set; }
        [JsonProperty("singleProviderLogin")]
        public bool SingleProviderLogin { get; set; }
    }
}
