namespace Codacy.Models
{
    public class RepositoryProblem
    {
        public string Message { get; set; }
        public List<ProblemLink> Actions { get; set; }
        public string Code { get; set; }
        public string Severity { get; set; }
    }
}
