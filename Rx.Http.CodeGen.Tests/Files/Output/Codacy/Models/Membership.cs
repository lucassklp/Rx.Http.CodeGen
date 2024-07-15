using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Membership
    {
        [JsonProperty("userRole")]
        public string UserRole { get; set; }
    }
}
