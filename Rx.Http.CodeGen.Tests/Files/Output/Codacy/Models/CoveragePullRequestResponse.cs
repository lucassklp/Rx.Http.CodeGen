using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CoveragePullRequestResponse
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
