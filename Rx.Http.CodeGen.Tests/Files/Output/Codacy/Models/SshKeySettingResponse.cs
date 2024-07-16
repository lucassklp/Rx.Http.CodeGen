using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SshKeySettingResponse
    {
        [JsonProperty("publicSshKey")]
        public string PublicSshKey { get; set; }
    }
}
