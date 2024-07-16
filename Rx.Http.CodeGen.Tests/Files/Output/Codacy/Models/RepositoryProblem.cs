using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryProblem
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("actions")]
        public List<ProblemLink> Actions { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("severity")]
        public string Severity { get; set; }
    }
}
