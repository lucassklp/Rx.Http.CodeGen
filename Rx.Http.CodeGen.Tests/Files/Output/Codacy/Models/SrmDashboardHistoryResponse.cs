using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmDashboardHistoryResponse
    {
        [JsonProperty("data")]
        public List<SrmHistoryDataPoint> Data { get; set; }
    }
}
