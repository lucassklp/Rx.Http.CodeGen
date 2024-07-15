using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Billing
    {
        [JsonProperty("isPremium")]
        public bool IsPremium { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("monthly")]
        public bool Monthly { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }
        [JsonProperty("pricedPerUser")]
        public bool PricedPerUser { get; set; }
    }
}
