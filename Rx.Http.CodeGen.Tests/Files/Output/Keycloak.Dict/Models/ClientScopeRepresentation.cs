namespace Keycloak.Dict.Models
{
    public class ClientScopeRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Protocol { get; set; }
        public Dictionary<string, object> Attributes { get; set; }
        public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
    }
}
