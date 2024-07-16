using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupUserResponse
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("error_details")]
        public ErrorDetails ErrorDetails { get; set; }
    }
}
