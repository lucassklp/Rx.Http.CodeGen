using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CommitDeltaIssue
    {
        [JsonProperty("commitIssue")]
        public CommitIssue CommitIssue { get; set; }
        [JsonProperty("deltaType")]
        public string DeltaType { get; set; }
    }
}
