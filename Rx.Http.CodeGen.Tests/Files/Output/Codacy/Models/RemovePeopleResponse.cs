using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RemovePeopleResponse
    {
        [JsonProperty("success")]
        public List<RemovePeopleEmailStatus> Success { get; set; }
        [JsonProperty("failed")]
        public List<RemovePeopleEmailStatus> Failed { get; set; }
    }
}
