using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SegmentsSyncStatusResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
