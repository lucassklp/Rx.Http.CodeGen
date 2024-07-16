using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class DsGroupRequest
    {
        [JsonProperty("ds_group_id")]
        public string DsGroupId { get; set; }
    }
}
