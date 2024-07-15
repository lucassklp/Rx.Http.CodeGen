using Newtonsoft.Json;

namespace Codacy.Models
{
    public class FileWithAnalysisInfo
    {
        [JsonProperty("fileId")]
        public int FileId { get; set; }
        [JsonProperty("branchId")]
        public int BranchId { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("totalIssues")]
        public int TotalIssues { get; set; }
        [JsonProperty("complexity")]
        public int Complexity { get; set; }
        [JsonProperty("grade")]
        public int Grade { get; set; }
        [JsonProperty("gradeLetter")]
        public string GradeLetter { get; set; }
        [JsonProperty("coverage")]
        public int Coverage { get; set; }
        [JsonProperty("coverageWithDecimals")]
        public double CoverageWithDecimals { get; set; }
        [JsonProperty("duplication")]
        public int Duplication { get; set; }
        [JsonProperty("linesOfCode")]
        public int LinesOfCode { get; set; }
        [JsonProperty("sourceLinesOfCode")]
        public int SourceLinesOfCode { get; set; }
        [JsonProperty("numberOfMethods")]
        public int NumberOfMethods { get; set; }
        [JsonProperty("numberOfClones")]
        public int NumberOfClones { get; set; }
    }
}
