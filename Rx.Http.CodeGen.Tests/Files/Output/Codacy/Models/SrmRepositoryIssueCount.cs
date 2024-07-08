namespace Codacy.Models
{
    public class SrmRepositoryIssueCount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Critical { get; set; }
        public int High { get; set; }
        public int Medium { get; set; }
        public int Low { get; set; }
    }
}
