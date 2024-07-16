using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityManagerBody
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }
    }
}
