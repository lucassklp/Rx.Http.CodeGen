namespace Codacy.Models
{
    public class ListRepositoriesFollowingGatePolicyResultResponse
    {
        public List<RepositoryIdentification> Data { get; set; }
        public PaginationInfo Pagination { get; set; }
    }
}
