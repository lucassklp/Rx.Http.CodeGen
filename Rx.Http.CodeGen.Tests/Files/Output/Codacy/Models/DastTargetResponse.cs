using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DastTargetResponse
    {
        [JsonProperty("data")]
        public DastTarget Data { get; set; }
    }
}
