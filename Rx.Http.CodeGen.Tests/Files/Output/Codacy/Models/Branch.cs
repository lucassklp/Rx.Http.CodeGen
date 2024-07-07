namespace Codacy.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsEnabled { get; set; }
        public string LastUpdated { get; set; }
        public string BranchType { get; set; }
        public string LastCommit { get; set; }
    }
}
