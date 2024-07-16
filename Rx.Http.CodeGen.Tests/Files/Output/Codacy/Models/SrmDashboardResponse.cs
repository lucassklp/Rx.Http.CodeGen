using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmDashboardResponse
    {
        [JsonProperty("data")]
        public SrmDashboard Data { get; set; }
    }
}
