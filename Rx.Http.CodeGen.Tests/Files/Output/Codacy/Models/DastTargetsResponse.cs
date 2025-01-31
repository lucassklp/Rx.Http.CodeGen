using Newtonsoft.Json;

namespace Codacy.Models
{
    public class DastTargetsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public DastTarget Data { get; set; }
    }
}
