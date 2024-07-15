using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AnalysisTool
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isClientSide")]
        public bool IsClientSide { get; set; }
        [JsonProperty("settings")]
        public AnalysisToolSettings Settings { get; set; }
    }
}
