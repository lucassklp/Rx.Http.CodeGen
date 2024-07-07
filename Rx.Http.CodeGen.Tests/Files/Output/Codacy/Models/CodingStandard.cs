namespace Codacy.Models
{
    public class CodingStandard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDraft { get; set; }
        public bool IsDefault { get; set; }
        public List<string> Languages { get; set; }
        public CodingStandardMeta Meta { get; set; }
    }
}
