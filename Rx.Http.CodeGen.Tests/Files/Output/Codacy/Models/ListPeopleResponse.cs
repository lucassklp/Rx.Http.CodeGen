using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ListPeopleResponse
    {
        [JsonProperty("data")]
        public List<Person> Data { get; set; }
        [JsonProperty("pagination")]
        public PaginationInfo Pagination { get; set; }
    }
}
