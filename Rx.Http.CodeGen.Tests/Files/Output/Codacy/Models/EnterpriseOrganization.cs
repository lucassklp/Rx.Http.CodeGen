using Newtonsoft.Json;

namespace Codacy.Models
{
    public class EnterpriseOrganization
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("remoteId")]
        public string RemoteId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("userRole")]
        public string UserRole { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }
}
