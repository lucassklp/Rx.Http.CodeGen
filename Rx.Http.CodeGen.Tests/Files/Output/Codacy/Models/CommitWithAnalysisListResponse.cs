namespace Codacy.Models
{
    public class CommitWithAnalysisListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<CommitWithAnalysis> Data { get; set; }
    }
}
