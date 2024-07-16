using Newtonsoft.Json;

namespace Codacy.Models
{
    public class UserResponse
    {
        [JsonProperty("data")]
        public User Data { get; set; }
    }
}
