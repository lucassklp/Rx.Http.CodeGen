using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ApiTokenResponse
    {
        [JsonProperty("data")]
        public ApiToken Data { get; set; }
    }
}
