using Newtonsoft.Json;

namespace Codacy.Models
{
    public class ChurnFeedback
    {
        [JsonProperty("joinReason")]
        public Reason JoinReason { get; set; }
        [JsonProperty("cancelReason")]
        public Reason CancelReason { get; set; }
    }
}
