using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationSimpleIdObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
