namespace Codacy.Models
{
    public class SrmDastReport
    {
        public string Id { get; set; }
        public int OrganizationId { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string GeneratedAt { get; set; }
        public string State { get; set; }
        public string Tool { get; set; }
        public string FailureReason { get; set; }
    }
}
