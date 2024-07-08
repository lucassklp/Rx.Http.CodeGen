namespace Codacy.Models
{
    public class Billing
    {
        public bool IsPremium { get; set; }
        public string Model { get; set; }
        public string Code { get; set; }
        public bool Monthly { get; set; }
        public int Price { get; set; }
        public bool PricedPerUser { get; set; }
    }
}
