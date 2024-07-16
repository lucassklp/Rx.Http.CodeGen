using Newtonsoft.Json;

namespace Codacy.Models
{
    public class LogsResponse
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
