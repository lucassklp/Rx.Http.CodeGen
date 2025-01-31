using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MetricGroupBy
    {
        [JsonProperty("groupBy")]
        public List<string> GroupBy { get; set; }
        [JsonProperty("sortDirection")]
        public string SortDirection { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
