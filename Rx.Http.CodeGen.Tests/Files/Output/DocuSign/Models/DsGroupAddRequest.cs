using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupAddRequest
    {
        [JsonProperty("group_name")]
        public string GroupName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
