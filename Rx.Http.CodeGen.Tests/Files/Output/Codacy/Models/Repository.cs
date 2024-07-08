namespace Codacy.Models
{
    public class Repository
    {
        public int RepositoryId { get; set; }
        public string Provider { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
        public string Visibility { get; set; }
        public string RemoteIdentifier { get; set; }
        public string LastUpdated { get; set; }
        public string Permission { get; set; }
        public List<RepositoryProblem> Problems { get; set; }
        public List<string> Languages { get; set; }
        public Branch DefaultBranch { get; set; }
        public Badges Badges { get; set; }
        public int CodingStandardId { get; set; }
        public string CodingStandardName { get; set; }
        public string AddedState { get; set; }
        public int GatePolicyId { get; set; }
        public string GatePolicyName { get; set; }
    }
}
