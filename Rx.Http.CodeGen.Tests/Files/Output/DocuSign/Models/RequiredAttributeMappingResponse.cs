using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class RequiredAttributeMappingResponse
    {
        [JsonProperty("required_attribute_id")]
        public int RequiredAttributeId { get; set; }
        [JsonProperty("required_attribute_name")]
        public string RequiredAttributeName { get; set; }
        [JsonProperty("required_attribute_friendly_name")]
        public string RequiredAttributeFriendlyName { get; set; }
        [JsonProperty("substitute_attribute_name")]
        public string SubstituteAttributeName { get; set; }
    }
}
