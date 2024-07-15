using Newtonsoft.Json;

namespace Codacy.Models
{
    public class OrganizationOnboardingStep
    {
        [JsonProperty("step")]
        public string Step { get; set; }
        [JsonProperty("isCompleted")]
        public bool IsCompleted { get; set; }
    }
}
