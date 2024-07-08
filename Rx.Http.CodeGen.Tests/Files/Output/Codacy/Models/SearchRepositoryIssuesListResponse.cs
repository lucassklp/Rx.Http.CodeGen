namespace Codacy.Models
{
    public class SearchRepositoryIssuesListResponse
    {
        public List<CommitIssue> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
