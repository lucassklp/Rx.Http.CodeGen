namespace Keycloak.Models
{
    public class ClientProfilesRepresentation
    {
        public List<ClientProfileRepresentation> Profiles { get; set; }
        public List<ClientProfileRepresentation> GlobalProfiles { get; set; }
    }
}
