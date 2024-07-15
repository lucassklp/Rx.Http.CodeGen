using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class NewUserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("language_culture")]
        public string LanguageCulture { get; set; }
        [JsonProperty("federated_status")]
        public string FederatedStatus { get; set; }
        [JsonProperty("accounts")]
        public List<NewUserResponseAccountProperties> Accounts { get; set; }
    }
}
