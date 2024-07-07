namespace Codacy.Models
{
    public class IssuesOverviewCounts
    {
        public List<Count> Categories { get; set; }
        public List<Count> Languages { get; set; }
        public List<Count> Levels { get; set; }
        public List<PatternsCount> Patterns { get; set; }
        public List<Count> Authors { get; set; }
    }
}
