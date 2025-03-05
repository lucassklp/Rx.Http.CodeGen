using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SegmentEntryDeprecated
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
