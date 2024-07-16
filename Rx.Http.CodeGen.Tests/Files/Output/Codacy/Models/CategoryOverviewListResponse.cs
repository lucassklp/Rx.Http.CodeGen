using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CategoryOverviewListResponse
    {
        [JsonProperty("data")]
        public List<CategoryOverview> Data { get; set; }
    }
}
