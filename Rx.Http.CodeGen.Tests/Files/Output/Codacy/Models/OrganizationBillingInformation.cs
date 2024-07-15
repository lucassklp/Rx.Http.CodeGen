using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationBillingInformation
    {
        [JsonProperty("numberOfSeats")]
        public int NumberOfSeats { get; set; }
        [JsonProperty("numberOfPurchasedSeats")]
        public int NumberOfPurchasedSeats { get; set; }
        [JsonProperty("paymentPlan")]
        public Billing PaymentPlan { get; set; }
        [JsonProperty("paymentGateway")]
        public string PaymentGateway { get; set; }
        [JsonProperty("priceInCents")]
        public int PriceInCents { get; set; }
        [JsonProperty("pricePerSeatInCents")]
        public int PricePerSeatInCents { get; set; }
        [JsonProperty("nextPaymentDate")]
        public string NextPaymentDate { get; set; }
        [JsonProperty("invoiceDetails")]
        public object InvoiceDetails { get; set; }
        [JsonProperty("taxes")]
        public List<Tax> Taxes { get; set; }
        [JsonProperty("subscriptions")]
        public List<OrganizationProductBillingPlan> Subscriptions { get; set; }
    }
}
