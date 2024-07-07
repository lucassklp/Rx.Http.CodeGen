namespace Codacy.Models
{
    public class PullRequestWithAnalysisListResponse
    {
        public List<PullRequestWithAnalysis> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
