using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitIssue
    {
        [JsonProperty("issueId")]
        public string IssueId { get; set; }
        [JsonProperty("resultDataId")]
        public int ResultDataId { get; set; }
        [JsonProperty("filePath")]
        public string FilePath { get; set; }
        [JsonProperty("fileId")]
        public int FileId { get; set; }
        [JsonProperty("patternInfo")]
        public PatternDetails PatternInfo { get; set; }
        [JsonProperty("toolInfo")]
        public ToolReference ToolInfo { get; set; }
        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("suggestion")]
        public string Suggestion { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("lineText")]
        public string LineText { get; set; }
        [JsonProperty("commitInfo")]
        public CommitReference CommitInfo { get; set; }
    }
}
