namespace Codacy.Models
{
    public class AuditLog
    {
        public AuditActor Actor { get; set; }
        public string Action { get; set; }
        public string Result { get; set; }
        public string Timestamp { get; set; }
        public string Source { get; set; }
        public string RepositoryName { get; set; }
        public string Description { get; set; }
        public object Details { get; set; }
        public string EntityId { get; set; }
    }
}
