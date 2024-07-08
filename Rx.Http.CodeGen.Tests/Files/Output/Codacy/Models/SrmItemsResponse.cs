namespace Codacy.Models
{
    public class SrmItemsResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<SrmItem> Data { get; set; }
    }
}
