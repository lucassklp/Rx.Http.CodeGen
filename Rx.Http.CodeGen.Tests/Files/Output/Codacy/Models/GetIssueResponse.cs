using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GetIssueResponse
    {
        [JsonProperty("data")]
        public CommitIssue Data { get; set; }
    }
}
