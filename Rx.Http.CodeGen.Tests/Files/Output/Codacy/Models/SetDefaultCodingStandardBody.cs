using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SetDefaultCodingStandardBody
    {
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }
}
