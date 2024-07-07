namespace Codacy.Models
{
    public class ApiError
    {
        public string Message { get; set; }
        public string InnerMessage { get; set; }
        public List<ProblemLink> Actions { get; set; }
    }
}
