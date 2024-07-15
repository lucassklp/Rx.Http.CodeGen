using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositorySuggestedAuthorsResponse
    {
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
        [JsonProperty("data")]
        public List<RepositorySuggestedAuthor> Data { get; set; }
    }
}
