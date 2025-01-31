using Newtonsoft.Json;

namespace Codacy.Models
{
    public class GitProviderAppPermissions
    {
        [JsonProperty("contentPermission")]
        public bool ContentPermission { get; set; }
        [JsonProperty("customPropertiesPermission")]
        public bool CustomPropertiesPermission { get; set; }
    }
}
