using Newtonsoft.Json;

namespace Codacy.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("mainEmail")]
        public string MainEmail { get; set; }
        [JsonProperty("otherEmails")]
        public List<string> OtherEmails { get; set; }
        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("intercomHash")]
        public string IntercomHash { get; set; }
        [JsonProperty("zendeskHash")]
        public string ZendeskHash { get; set; }
        [JsonProperty("shouldDoClientQualification")]
        public bool ShouldDoClientQualification { get; set; }
    }
}
