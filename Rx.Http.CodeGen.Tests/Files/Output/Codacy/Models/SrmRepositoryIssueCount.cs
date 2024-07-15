using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmRepositoryIssueCount
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("critical")]
        public int Critical { get; set; }
        [JsonProperty("high")]
        public int High { get; set; }
        [JsonProperty("medium")]
        public int Medium { get; set; }
        [JsonProperty("low")]
        public int Low { get; set; }
    }
}
