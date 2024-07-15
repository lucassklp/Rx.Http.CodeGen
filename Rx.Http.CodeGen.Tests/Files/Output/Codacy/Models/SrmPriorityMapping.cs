using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmPriorityMapping
    {
        [JsonProperty("priority")]
        public string Priority { get; set; }
        [JsonProperty("criteria")]
        public object Criteria { get; set; }
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }
}
