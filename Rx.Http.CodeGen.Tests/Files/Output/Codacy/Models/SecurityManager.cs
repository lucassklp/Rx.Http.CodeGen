using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityManager
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }
}
