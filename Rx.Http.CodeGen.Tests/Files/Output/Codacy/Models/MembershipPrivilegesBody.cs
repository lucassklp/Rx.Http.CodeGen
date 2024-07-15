using Newtonsoft.Json;

namespace Codacy.Models
{
    public class MembershipPrivilegesBody
    {
        [JsonProperty("permission")]
        public string Permission { get; set; }
    }
}
