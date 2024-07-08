namespace Keycloak.Models
{
    public class GroupRepresentation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public object Attributes { get; set; }
        public List<string> RealmRoles { get; set; }
        public object ClientRoles { get; set; }
        public List<GroupRepresentation> SubGroups { get; set; }
        public object Access { get; set; }
    }
}
