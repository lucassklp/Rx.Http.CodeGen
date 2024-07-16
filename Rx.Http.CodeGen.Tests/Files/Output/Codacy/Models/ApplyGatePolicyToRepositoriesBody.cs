using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ApplyGatePolicyToRepositoriesBody
    {
        [JsonProperty("link")]
        public List<string> Link { get; set; }
        [JsonProperty("unlink")]
        public List<string> Unlink { get; set; }
    }
}
