using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationWithMetaResponse
    {
        [JsonProperty("data")]
        public OrganizationWithMeta Data { get; set; }
    }
}
