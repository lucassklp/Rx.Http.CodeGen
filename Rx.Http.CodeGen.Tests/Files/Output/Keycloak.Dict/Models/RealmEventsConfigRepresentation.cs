using Newtonsoft.Json;

namespace Keycloak.Dict.Models
{
    public class RealmEventsConfigRepresentation
    {
        [JsonProperty("eventsEnabled")]
        public bool EventsEnabled { get; set; }
        [JsonProperty("eventsExpiration")]
        public int EventsExpiration { get; set; }
        [JsonProperty("eventsListeners")]
        public List<string> EventsListeners { get; set; }
        [JsonProperty("enabledEventTypes")]
        public List<string> EnabledEventTypes { get; set; }
        [JsonProperty("adminEventsEnabled")]
        public bool AdminEventsEnabled { get; set; }
        [JsonProperty("adminEventsDetailsEnabled")]
        public bool AdminEventsDetailsEnabled { get; set; }
    }
}
