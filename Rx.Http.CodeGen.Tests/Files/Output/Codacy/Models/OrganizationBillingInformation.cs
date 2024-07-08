namespace Codacy.Models
{
    public class OrganizationBillingInformation
    {
        public int NumberOfSeats { get; set; }
        public int NumberOfPurchasedSeats { get; set; }
        public Billing PaymentPlan { get; set; }
        public string PaymentGateway { get; set; }
        public int PriceInCents { get; set; }
        public int PricePerSeatInCents { get; set; }
        public string NextPaymentDate { get; set; }
        public object InvoiceDetails { get; set; }
        public List<Tax> Taxes { get; set; }
        public List<OrganizationProductBillingPlan> Subscriptions { get; set; }
    }
}
