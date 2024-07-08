namespace Keycloak.Models
{
    public class UserConsentRepresentation
    {
        public string ClientId { get; set; }
        public List<string> GrantedClientScopes { get; set; }
        public int CreatedDate { get; set; }
        public int LastUpdatedDate { get; set; }
        public List<string> GrantedRealmRoles { get; set; }
    }
}
