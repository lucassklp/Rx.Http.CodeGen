using Newtonsoft.Json;

namespace Codacy.Models
{
    public class EnterpriseEntity
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("userRole")]
        public string UserRole { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
    }
}
