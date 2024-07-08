namespace Codacy.Models
{
    public class CommitFileClone
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public List<CloneDuplicationBlock> Clones { get; set; }
    }
}
