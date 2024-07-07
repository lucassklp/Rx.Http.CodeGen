namespace Codacy.Models
{
    public class BranchListResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<Branch> Data { get; set; }
    }
}
