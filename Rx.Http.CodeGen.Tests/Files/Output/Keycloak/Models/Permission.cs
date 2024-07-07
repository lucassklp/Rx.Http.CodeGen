namespace Keycloak.Models
{
    public class Permission
    {
        public string Rsid { get; set; }
        public string Rsname { get; set; }
        public List<string> Scopes { get; set; }
        public object Claims { get; set; }
    }
}
