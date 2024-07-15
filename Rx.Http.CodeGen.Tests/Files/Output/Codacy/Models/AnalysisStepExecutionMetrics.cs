using Newtonsoft.Json;

namespace Codacy.Models
{
    public class AnalysisStepExecutionMetrics
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("start")]
        public string Start { get; set; }
        [JsonProperty("end")]
        public string End { get; set; }
        [JsonProperty("activeExecutionTime")]
        public int ActiveExecutionTime { get; set; }
        [JsonProperty("totalExecutionTime")]
        public int TotalExecutionTime { get; set; }
        [JsonProperty("stackTrace")]
        public string StackTrace { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
