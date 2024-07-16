using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SuggestedAuthorsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<SuggestedAuthor> Data { get; set; }
    }
}
