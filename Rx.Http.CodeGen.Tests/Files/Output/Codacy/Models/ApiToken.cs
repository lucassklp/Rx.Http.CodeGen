using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ApiToken
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
