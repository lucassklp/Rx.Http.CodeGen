using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ProjectCommitStat
    {
        [JsonProperty("projectId")]
        public int ProjectId { get; set; }
        [JsonProperty("firstCommit")]
        public string FirstCommit { get; set; }
        [JsonProperty("lastCommit")]
        public string LastCommit { get; set; }
        [JsonProperty("numberOfCommits")]
        public int NumberOfCommits { get; set; }
    }
}
