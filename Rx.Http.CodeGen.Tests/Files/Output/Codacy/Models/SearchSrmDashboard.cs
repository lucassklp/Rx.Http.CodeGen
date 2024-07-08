namespace Codacy.Models
{
    public class SearchSrmDashboard
    {
        public List<string> Repositories { get; set; }
        public List<string> Priorities { get; set; }
        public List<string> Categories { get; set; }
        public List<string> ScanTypes { get; set; }
    }
}
