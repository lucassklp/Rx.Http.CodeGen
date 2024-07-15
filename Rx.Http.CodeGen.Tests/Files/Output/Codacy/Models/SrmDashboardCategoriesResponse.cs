using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmDashboardCategoriesResponse
    {
        [JsonProperty("data")]
        public List<SrmCategoryIssueCount> Data { get; set; }
    }
}
