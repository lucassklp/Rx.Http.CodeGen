using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class PermissionProfileRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
