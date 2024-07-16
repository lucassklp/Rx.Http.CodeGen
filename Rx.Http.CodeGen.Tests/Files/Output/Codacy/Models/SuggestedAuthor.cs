using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SuggestedAuthor
    {
        [JsonProperty("commitEmail")]
        public string CommitEmail { get; set; }
        [JsonProperty("totalProjects")]
        public int TotalProjects { get; set; }
        [JsonProperty("totalCommits")]
        public int TotalCommits { get; set; }
        [JsonProperty("lastCommit")]
        public string LastCommit { get; set; }
        [JsonProperty("projectCommitStats")]
        public List<ProjectCommitStat> ProjectCommitStats { get; set; }
    }
}
