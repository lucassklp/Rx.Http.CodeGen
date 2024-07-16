using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositorySuggestedAuthor
    {
        [JsonProperty("commitEmail")]
        public string CommitEmail { get; set; }
        [JsonProperty("projectCommitStat")]
        public ProjectCommitStat ProjectCommitStat { get; set; }
    }
}
