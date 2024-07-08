namespace Keycloak.Dict.Models
{
    public class RealmEventsConfigRepresentation
    {
        public bool EventsEnabled { get; set; }
        public int EventsExpiration { get; set; }
        public List<string> EventsListeners { get; set; }
        public List<string> EnabledEventTypes { get; set; }
        public bool AdminEventsEnabled { get; set; }
        public bool AdminEventsDetailsEnabled { get; set; }
    }
}
