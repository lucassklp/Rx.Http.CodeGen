using Newtonsoft.Json;

namespace Codacy.Models
{
    public class StandardPatternConflict
    {
        [JsonProperty("patternId")]
        public string PatternId { get; set; }
        [JsonProperty("conflicts")]
        public List<StandardParameterConflict> Conflicts { get; set; }
    }
}
