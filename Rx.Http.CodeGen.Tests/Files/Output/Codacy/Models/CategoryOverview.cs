namespace Codacy.Models
{
    public class CategoryOverview
    {
        public int CommitId { get; set; }
        public Category Category { get; set; }
        public double Percentage { get; set; }
        public int TotalResults { get; set; }
    }
}
