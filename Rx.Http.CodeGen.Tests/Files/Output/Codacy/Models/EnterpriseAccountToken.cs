using Newtonsoft.Json;

namespace Codacy.Models
{
    public class EnterpriseAccountToken
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }
    }
}
