using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SegmentKeyWithId
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
