namespace Codacy.Models
{
    public class LeaveOrgCheckResult
    {
        public bool CanLeave { get; set; }
        public string Message { get; set; }
        public LeaveOrgProblem Reason { get; set; }
    }
}
