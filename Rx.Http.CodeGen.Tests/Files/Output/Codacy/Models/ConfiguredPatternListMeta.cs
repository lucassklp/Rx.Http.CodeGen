using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ConfiguredPatternListMeta
    {
        [JsonProperty("totalEnabled")]
        public int TotalEnabled { get; set; }
    }
}
