using Newtonsoft.Json;

namespace Codacy.Models
{
    public class JoinResponse
    {
        [JsonProperty("organizationIdentifier")]
        public int OrganizationIdentifier { get; set; }
        [JsonProperty("joinStatus")]
        public string JoinStatus { get; set; }
    }
}
