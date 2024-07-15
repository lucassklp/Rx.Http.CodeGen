using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationOnboardingProgressResponse
    {
        [JsonProperty("data")]
        public List<OrganizationOnboardingStep> Data { get; set; }
    }
}
