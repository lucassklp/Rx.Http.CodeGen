using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CodingStandardTool
    {
        [JsonProperty("codingStandardId")]
        public int CodingStandardId { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
    }
}
