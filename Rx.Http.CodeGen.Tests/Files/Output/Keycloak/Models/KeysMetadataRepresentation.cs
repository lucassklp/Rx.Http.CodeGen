namespace Keycloak.Models
{
    public class KeysMetadataRepresentation
    {
        public object Active { get; set; }
        public List<KeyMetadataRepresentation> Keys { get; set; }
    }
}
