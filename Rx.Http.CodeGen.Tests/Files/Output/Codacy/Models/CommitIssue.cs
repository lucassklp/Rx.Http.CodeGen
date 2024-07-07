namespace Codacy.Models
{
    public class CommitIssue
    {
        public string IssueId { get; set; }
        public int ResultDataId { get; set; }
        public string FilePath { get; set; }
        public int FileId { get; set; }
        public PatternDetails PatternInfo { get; set; }
        public ToolReference ToolInfo { get; set; }
        public int LineNumber { get; set; }
        public string Message { get; set; }
        public string Suggestion { get; set; }
        public string Language { get; set; }
        public string LineText { get; set; }
        public CommitReference CommitInfo { get; set; }
    }
}
