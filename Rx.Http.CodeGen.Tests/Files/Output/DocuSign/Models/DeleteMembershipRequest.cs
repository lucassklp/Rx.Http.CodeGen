using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DeleteMembershipRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
