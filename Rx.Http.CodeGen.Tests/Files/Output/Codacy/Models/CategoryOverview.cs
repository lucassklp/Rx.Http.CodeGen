using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CategoryOverview
    {
        [JsonProperty("commitId")]
        public int CommitId { get; set; }
        [JsonProperty("category")]
        public Category Category { get; set; }
        [JsonProperty("percentage")]
        public double Percentage { get; set; }
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
    }
}
