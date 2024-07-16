using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class UsersDrilldownResponse
    {
        [JsonProperty("users")]
        public List<UserDrilldownResponse> Users { get; set; }
    }
}
