using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileQualityInfo
    {
        [JsonProperty("totalIssues")]
        public int TotalIssues { get; set; }
        [JsonProperty("complexity")]
        public int Complexity { get; set; }
        [JsonProperty("grade")]
        public int Grade { get; set; }
        [JsonProperty("gradeLetter")]
        public string GradeLetter { get; set; }
        [JsonProperty("duplication")]
        public int Duplication { get; set; }
        [JsonProperty("duplicatedLinesOfCode")]
        public int DuplicatedLinesOfCode { get; set; }
    }
}
