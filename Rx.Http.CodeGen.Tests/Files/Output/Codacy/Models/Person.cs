namespace Codacy.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Emails { get; set; }
        public int UserId { get; set; }
        public int CommitterId { get; set; }
        public string LastLogin { get; set; }
        public string LastAnalysis { get; set; }
        public bool IsActive { get; set; }
        public bool CanBeRemoved { get; set; }
        public int LastCommitId { get; set; }
        public string ProviderId { get; set; }
        public string ProviderLogin { get; set; }
        public bool IsProviderRegistered { get; set; }
    }
}
