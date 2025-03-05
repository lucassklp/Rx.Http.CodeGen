using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DimensionsFilter
    {
        [JsonProperty("dimension")]
        public string Dimension { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
