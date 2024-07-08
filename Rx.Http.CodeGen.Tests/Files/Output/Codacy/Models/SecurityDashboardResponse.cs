namespace Codacy.Models
{
    public class SecurityDashboardResponse
    {
        public SecurityDashboardMetrics ItemsOverdue { get; set; }
        public SecurityDashboardMetrics ItemsDueSoon { get; set; }
        public SecurityDashboardMetrics PastSlaMisses { get; set; }
        public SecurityDashboardMetrics PastSlaOnTime { get; set; }
    }
}
