using Newtonsoft.Json;

namespace Keycloak.Models
{
    public class AddressClaimSet
    {
        [JsonProperty("formatted")]
        public string Formatted { get; set; }
        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }
        [JsonProperty("locality")]
        public string Locality { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
