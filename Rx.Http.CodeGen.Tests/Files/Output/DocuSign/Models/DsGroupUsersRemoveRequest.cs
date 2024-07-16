using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupUsersRemoveRequest
    {
        [JsonProperty("user_ids")]
        public List<string> UserIds { get; set; }
        [JsonProperty("user_emails")]
        public List<string> UserEmails { get; set; }
    }
}
