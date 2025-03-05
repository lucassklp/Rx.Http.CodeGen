using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AddEnterpriseAccountTokenBody
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
    }
}
