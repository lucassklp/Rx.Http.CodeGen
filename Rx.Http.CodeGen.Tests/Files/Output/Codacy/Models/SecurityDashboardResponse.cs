using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityDashboardResponse
    {
        [JsonProperty("items_overdue")]
        public SecurityDashboardMetrics ItemsOverdue { get; set; }
        [JsonProperty("items_due_soon")]
        public SecurityDashboardMetrics ItemsDueSoon { get; set; }
        [JsonProperty("past_sla_misses")]
        public SecurityDashboardMetrics PastSlaMisses { get; set; }
        [JsonProperty("past_sla_on_time")]
        public SecurityDashboardMetrics PastSlaOnTime { get; set; }
    }
}
