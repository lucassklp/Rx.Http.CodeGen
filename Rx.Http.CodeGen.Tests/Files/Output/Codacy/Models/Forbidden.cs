namespace Codacy.Models
{
    public class Forbidden
    {
        public string Message { get; set; }
        public string InnerMessage { get; set; }
        public List<ProblemLink> Actions { get; set; }
        public string Error { get; set; }
    }
}
