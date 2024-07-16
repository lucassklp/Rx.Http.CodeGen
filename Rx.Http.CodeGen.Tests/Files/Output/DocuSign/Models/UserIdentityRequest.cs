using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UserIdentityRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
