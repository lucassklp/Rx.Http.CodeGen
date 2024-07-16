using Newtonsoft.Json;

namespace Codacy.Models
{
    public class PullRequestOwner
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
