using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class GlobalRequestResult
    {
        [JsonProperty("successRequests")]
        public List<string> SuccessRequests { get; set; }
        [JsonProperty("failedRequests")]
        public List<string> FailedRequests { get; set; }
    }
}
