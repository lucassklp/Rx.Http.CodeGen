namespace Keycloak.Models
{
    public class ComponentExportRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProviderId { get; set; }
        public string SubType { get; set; }
        public object SubComponents { get; set; }
        public object Config { get; set; }
    }
}
