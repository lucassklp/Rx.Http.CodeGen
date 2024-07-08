namespace Keycloak.Models
{
    public class PublishedRealmRepresentation
    {
        public string Realm { get; set; }
        public string PublicKey { get; set; }
        public string TokenService { get; set; }
        public string AccountService { get; set; }
        public int TokensNotBefore { get; set; }
    }
}
