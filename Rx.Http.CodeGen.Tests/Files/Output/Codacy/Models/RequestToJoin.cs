namespace Codacy.Models
{
    public class RequestToJoin
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public int NumberOfCommits { get; set; }
        public int NumberOfRepositories { get; set; }
        public string LastActivity { get; set; }
        public string CreationDate { get; set; }
    }
}
