namespace Codacy.Models
{
    public class CloneDuplicationBlock
    {
        public string Path { get; set; }
        public int FileId { get; set; }
        public int FileDataId { get; set; }
        public int FromLine { get; set; }
        public int ToLine { get; set; }
    }
}
