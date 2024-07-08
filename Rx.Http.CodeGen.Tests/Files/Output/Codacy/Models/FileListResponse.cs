namespace Codacy.Models
{
    public class FileListResponse
    {
        public List<FileWithAnalysisInfo> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
