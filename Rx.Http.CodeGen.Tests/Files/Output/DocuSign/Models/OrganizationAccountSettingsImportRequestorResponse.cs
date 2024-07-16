using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationAccountSettingsImportRequestorResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
