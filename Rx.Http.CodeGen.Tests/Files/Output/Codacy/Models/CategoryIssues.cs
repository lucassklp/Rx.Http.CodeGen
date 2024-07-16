using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CategoryIssues
    {
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
        [JsonProperty("numberOfIssues")]
        public int NumberOfIssues { get; set; }
    }
}
