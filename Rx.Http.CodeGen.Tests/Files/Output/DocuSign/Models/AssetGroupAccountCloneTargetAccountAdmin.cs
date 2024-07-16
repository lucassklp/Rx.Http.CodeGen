using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class AssetGroupAccountCloneTargetAccountAdmin
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}
