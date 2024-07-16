using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class SettingResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public object Value { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
