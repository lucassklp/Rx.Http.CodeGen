namespace Codacy.Models
{
    public class ListRequestsToJoinResponse
    {
        public PaginationInfo Pagination { get; set; }
        public List<RequestToJoin> Data { get; set; }
    }
}
