using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupUsersAddRequest
    {
        [JsonProperty("user_ids")]
        public List<string> UserIds { get; set; }
    }
}
