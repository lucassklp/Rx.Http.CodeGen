namespace Keycloak.Dict.Models
{
    public class ClientProfileRepresentation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ClientPolicyExecutorRepresentation> Executors { get; set; }
    }
}
