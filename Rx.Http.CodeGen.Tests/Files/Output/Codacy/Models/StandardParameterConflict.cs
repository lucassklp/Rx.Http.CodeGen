using Newtonsoft.Json;

namespace Codacy.Models
{
    public class StandardParameterConflict
    {
        [JsonProperty("standard")]
        public CodingStandardInfo Standard { get; set; }
        [JsonProperty("parameters")]
        public List<ConfiguredParameter> Parameters { get; set; }
    }
}
