namespace Codacy.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainEmail { get; set; }
        public List<string> OtherEmails { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string Created { get; set; }
        public string IntercomHash { get; set; }
        public string ZendeskHash { get; set; }
        public bool ShouldDoClientQualification { get; set; }
    }
}
