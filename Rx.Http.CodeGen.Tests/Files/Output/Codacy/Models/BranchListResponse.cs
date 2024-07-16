using Newtonsoft.Json;

namespace Codacy.Models
{
    public class BranchListResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<Branch> Data { get; set; }
    }
}
