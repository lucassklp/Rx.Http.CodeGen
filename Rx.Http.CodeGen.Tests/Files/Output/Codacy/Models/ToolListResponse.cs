namespace Codacy.Models
{
    public class ToolListResponse
    {
        public List<Tool> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
