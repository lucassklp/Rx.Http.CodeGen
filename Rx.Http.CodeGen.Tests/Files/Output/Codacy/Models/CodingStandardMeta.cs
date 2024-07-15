using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandardMeta
    {
        [JsonProperty("enabledToolsCount")]
        public int EnabledToolsCount { get; set; }
        [JsonProperty("enabledPatternsCount")]
        public int EnabledPatternsCount { get; set; }
        [JsonProperty("linkedRepositoriesCount")]
        public int LinkedRepositoriesCount { get; set; }
    }
}
