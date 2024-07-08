namespace Keycloak.Dict.Models
{
    public class KeysMetadataRepresentation
    {
        public Dictionary<string, object> Active { get; set; }
        public List<KeyMetadataRepresentation> Keys { get; set; }
    }
}
