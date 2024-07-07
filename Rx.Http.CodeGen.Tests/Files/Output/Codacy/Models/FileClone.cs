namespace Codacy.Models
{
    public class FileClone
    {
        public int Id { get; set; }
        public List<CloneDuplicationBlock> Occurrences { get; set; }
    }
}
