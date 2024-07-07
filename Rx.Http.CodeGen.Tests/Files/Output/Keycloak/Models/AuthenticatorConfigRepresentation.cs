namespace Keycloak.Models
{
    public class AuthenticatorConfigRepresentation
    {
        public string Id { get; set; }
        public string Alias { get; set; }
        public object Config { get; set; }
    }
}
