using Newtonsoft.Json;

namespace Codacy.Models
{
    public class LeaveOrgCheckResult
    {
        [JsonProperty("canLeave")]
        public bool CanLeave { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("reason")]
        public LeaveOrgProblem Reason { get; set; }
    }
}
