using Newtonsoft.Json;

namespace Codacy.Models
{
    public class Commit
    {
        [JsonProperty("sha")]
        public string Sha { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("commitTimestamp")]
        public string CommitTimestamp { get; set; }
        [JsonProperty("authorName")]
        public string AuthorName { get; set; }
        [JsonProperty("authorEmail")]
        public string AuthorEmail { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("startedAnalysis")]
        public string StartedAnalysis { get; set; }
        [JsonProperty("endedAnalysis")]
        public string EndedAnalysis { get; set; }
        [JsonProperty("isMergeCommit")]
        public bool IsMergeCommit { get; set; }
        [JsonProperty("gitHref")]
        public string GitHref { get; set; }
        [JsonProperty("parents")]
        public List<string> Parents { get; set; }
    }
}
