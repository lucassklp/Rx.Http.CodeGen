using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DeleteMembershipResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("error_details")]
        public ErrorDetails ErrorDetails { get; set; }
    }
}
