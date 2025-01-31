using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SeatsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<Seat> Data { get; set; }
    }
}
