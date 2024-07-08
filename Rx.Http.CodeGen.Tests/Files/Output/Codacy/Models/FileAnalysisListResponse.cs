namespace Codacy.Models
{
    public class FileAnalysisListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<FileDeltaAnalysis> Data { get; set; }
    }
}
