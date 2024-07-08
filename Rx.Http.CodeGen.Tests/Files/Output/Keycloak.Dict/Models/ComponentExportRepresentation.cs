namespace Keycloak.Dict.Models
{
    public class ComponentExportRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProviderId { get; set; }
        public string SubType { get; set; }
        public Dictionary<string, object> SubComponents { get; set; }
        public Dictionary<string, object> Config { get; set; }
    }
}
