using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AnalysisToolsResponse
    {
        [JsonProperty("data")]
        public List<AnalysisTool> Data { get; set; }
    }
}
