using Newtonsoft.Json;

namespace Codacy.Models
{
    public class BranchRequiredChecksResponse
    {
        [JsonProperty("data")]
        public BranchRequiredChecks Data { get; set; }
    }
}
