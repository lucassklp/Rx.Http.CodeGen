using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AddOrganizationBody
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("remoteIdentifier")]
        public string RemoteIdentifier { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("products")]
        public List<string> Products { get; set; }
    }
}
