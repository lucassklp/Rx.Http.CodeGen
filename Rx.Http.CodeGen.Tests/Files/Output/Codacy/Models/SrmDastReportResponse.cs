namespace Codacy.Models
{
    public class SrmDastReportResponse
    {
        public List<SrmDastReport> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
