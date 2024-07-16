using Newtonsoft.Json;

namespace Codacy.Models
{
    public class UpdatePatternsBody
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
