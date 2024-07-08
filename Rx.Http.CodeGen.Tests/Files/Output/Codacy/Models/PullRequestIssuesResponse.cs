namespace Codacy.Models
{
    public class PullRequestIssuesResponse
    {
        public bool Analyzed { get; set; }
        public List<CommitDeltaIssue> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
