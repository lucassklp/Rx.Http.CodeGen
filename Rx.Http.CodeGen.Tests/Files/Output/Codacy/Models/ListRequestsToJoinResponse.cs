using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ListRequestsToJoinResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<RequestToJoin> Data { get; set; }
    }
}
