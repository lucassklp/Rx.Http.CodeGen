namespace Codacy.Models
{
    public class Organization
    {
        public int Identifier { get; set; }
        public string RemoteIdentifier { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Created { get; set; }
        public string Provider { get; set; }
        public string JoinMode { get; set; }
        public string Type { get; set; }
        public string JoinStatus { get; set; }
        public bool SingleProviderLogin { get; set; }
    }
}
