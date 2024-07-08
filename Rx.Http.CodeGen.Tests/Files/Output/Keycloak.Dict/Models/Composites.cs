namespace Keycloak.Dict.Models
{
    public class Composites
    {
        public List<string> Realm { get; set; }
        public Dictionary<string, object> Client { get; set; }
        public Dictionary<string, object> Application { get; set; }
    }
}
