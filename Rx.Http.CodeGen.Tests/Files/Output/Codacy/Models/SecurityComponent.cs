using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SecurityComponent
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("ok")]
        public int Ok { get; set; }
    }
}
