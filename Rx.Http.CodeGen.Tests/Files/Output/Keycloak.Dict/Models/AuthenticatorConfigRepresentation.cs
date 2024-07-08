namespace Keycloak.Dict.Models
{
    public class AuthenticatorConfigRepresentation
    {
        public string Id { get; set; }
        public string Alias { get; set; }
        public Dictionary<string, object> Config { get; set; }
    }
}
