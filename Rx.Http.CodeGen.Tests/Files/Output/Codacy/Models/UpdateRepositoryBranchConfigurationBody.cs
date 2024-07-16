using Newtonsoft.Json;

namespace Codacy.Models
{
    public class UpdateRepositoryBranchConfigurationBody
    {
        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
    }
}
