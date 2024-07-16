using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchRepositoryIssuesBody
    {
        [JsonProperty("branchName")]
        public string BranchName { get; set; }
        [JsonProperty("patternIds")]
        public List<string> PatternIds { get; set; }
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }
        [JsonProperty("categories")]
        public List<string> Categories { get; set; }
        [JsonProperty("levels")]
        public List<string> Levels { get; set; }
        [JsonProperty("authorEmails")]
        public List<string> AuthorEmails { get; set; }
    }
}
