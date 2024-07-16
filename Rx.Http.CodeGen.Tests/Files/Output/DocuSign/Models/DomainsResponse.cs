using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DomainsResponse
    {
        [JsonProperty("reserved_domains")]
        public List<DomainResponse> ReservedDomains { get; set; }
    }
}
