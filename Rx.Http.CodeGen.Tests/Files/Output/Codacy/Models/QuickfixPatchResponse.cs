using Newtonsoft.Json;

namespace Codacy.Models
{
    public class QuickfixPatchResponse
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
