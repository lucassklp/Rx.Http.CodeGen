namespace Codacy.Models
{
    public class ProductSubscription
    {
        public string Product { get; set; }
        public OrganizationBillingPlan Plan { get; set; }
        public ProductPaywall Paywall { get; set; }
    }
}
