using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmItemsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<SrmItem> Data { get; set; }
    }
}
