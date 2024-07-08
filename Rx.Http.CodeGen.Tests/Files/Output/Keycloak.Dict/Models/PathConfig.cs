namespace Keycloak.Dict.Models
{
    public class PathConfig
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public List<MethodConfig> Methods { get; set; }
        public List<string> Scopes { get; set; }
        public string Id { get; set; }
        public EnforcementMode EnforcementMode { get; set; }
        public Dictionary<string, object> ClaimInformationPoint { get; set; }
        public bool Invalidated { get; set; }
        public bool StaticPath { get; set; }
        public bool Static { get; set; }
    }
}
