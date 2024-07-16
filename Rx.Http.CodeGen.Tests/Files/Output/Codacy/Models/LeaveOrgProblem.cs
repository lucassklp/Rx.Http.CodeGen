using Newtonsoft.Json;

namespace Codacy.Models
{
    public class LeaveOrgProblem
    {
        [JsonProperty("actions")]
        public List<ProblemLink> Actions { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
