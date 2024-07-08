namespace Codacy.Models
{
    public class CommitDeltaIssue
    {
        public CommitIssue CommitIssue { get; set; }
        public string DeltaType { get; set; }
    }
}
