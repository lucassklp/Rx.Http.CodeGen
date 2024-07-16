using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandardCategoriesPresets
    {
        [JsonProperty("bugRisk")]
        public int BugRisk { get; set; }
        [JsonProperty("security")]
        public int Security { get; set; }
        [JsonProperty("bestPractices")]
        public int BestPractices { get; set; }
        [JsonProperty("codeStyle")]
        public int CodeStyle { get; set; }
        [JsonProperty("documentation")]
        public int Documentation { get; set; }
    }
}
