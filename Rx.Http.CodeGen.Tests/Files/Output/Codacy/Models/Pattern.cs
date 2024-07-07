namespace Codacy.Models
{
    public class Pattern
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Level { get; set; }
        public string SeverityLevel { get; set; }
        public string Description { get; set; }
        public string Explanation { get; set; }
        public bool Enabled { get; set; }
        public List<string> Languages { get; set; }
        public int TimeToFix { get; set; }
        public List<Parameter> Parameters { get; set; }
    }
}
