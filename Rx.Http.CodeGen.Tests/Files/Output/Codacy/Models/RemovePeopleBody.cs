using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RemovePeopleBody
    {
        [JsonProperty("emails")]
        public List<string> Emails { get; set; }
    }
}
