using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityDashboardMetrics
    {
        [JsonProperty("12_month")]
        public int _12Month { get; set; }
        [JsonProperty("30_day_variation")]
        public object _30DayVariation { get; set; }
    }
}
