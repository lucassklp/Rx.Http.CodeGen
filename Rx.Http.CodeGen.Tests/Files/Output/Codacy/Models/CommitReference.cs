namespace Codacy.Models
{
    public class CommitReference
    {
        public string Sha { get; set; }
        public string Commiter { get; set; }
        public string CommiterName { get; set; }
        public string Timestamp { get; set; }
    }
}
