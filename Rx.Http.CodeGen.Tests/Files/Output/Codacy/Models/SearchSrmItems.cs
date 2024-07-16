using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchSrmItems
    {
        [JsonProperty("repositories")]
        public List<string> Repositories { get; set; }
        [JsonProperty("priorities")]
        public List<string> Priorities { get; set; }
        [JsonProperty("statuses")]
        public List<string> Statuses { get; set; }
        [JsonProperty("categories")]
        public List<string> Categories { get; set; }
        [JsonProperty("scanTypes")]
        public List<string> ScanTypes { get; set; }
    }
}
