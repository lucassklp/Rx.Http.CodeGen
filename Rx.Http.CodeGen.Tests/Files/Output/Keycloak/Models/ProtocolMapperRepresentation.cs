namespace Keycloak.Models
{
    public class ProtocolMapperRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Protocol { get; set; }
        public string ProtocolMapper { get; set; }
        public bool ConsentRequired { get; set; }
        public string ConsentText { get; set; }
        public object Config { get; set; }
    }
}
