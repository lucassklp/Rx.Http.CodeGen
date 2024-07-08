namespace Keycloak.Dict.Models
{
    public class Permission
    {
        public string Rsid { get; set; }
        public string Rsname { get; set; }
        public List<string> Scopes { get; set; }
        public Dictionary<string, object> Claims { get; set; }
    }
}
