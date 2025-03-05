using Newtonsoft.Json;

namespace Codacy.Models
{
    public class EntityFilter
    {
        [JsonProperty("repositories")]
        public List<string> Repositories { get; set; }
        [JsonProperty("segmentIds")]
        public List<int> SegmentIds { get; set; }
    }
}
