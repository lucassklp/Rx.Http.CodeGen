using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ApplyCodingStandardToRepositoriesResult
    {
        [JsonProperty("successful")]
        public List<string> Successful { get; set; }
        [JsonProperty("failed")]
        public List<string> Failed { get; set; }
    }
}
