namespace Codacy.Models
{
    public class IgnoredIssuesListResponse
    {
        public List<IgnoredIssue> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
