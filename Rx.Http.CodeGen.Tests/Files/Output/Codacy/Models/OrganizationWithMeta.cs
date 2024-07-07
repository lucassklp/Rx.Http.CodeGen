namespace Codacy.Models
{
    public class OrganizationWithMeta
    {
        public Organization Organization { get; set; }
        public Membership Membership { get; set; }
        public Billing Billing { get; set; }
        public Paywall Paywall { get; set; }
        public OrganizationPaywall OrganizationPayWall { get; set; }
        public string AnalysisConfigurationMinimumPermission { get; set; }
        public List<ProductSubscription> Subscriptions { get; set; }
    }
}
