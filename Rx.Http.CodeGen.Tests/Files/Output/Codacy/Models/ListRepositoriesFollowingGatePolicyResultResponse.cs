using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ListRepositoriesFollowingGatePolicyResultResponse
    {
        [JsonProperty("data")]
        public List<RepositoryIdentification> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
