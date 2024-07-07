namespace Codacy.Models
{
    public class RepositoryWithAnalysisListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<RepositoryWithAnalysis> Data { get; set; }
    }
}
