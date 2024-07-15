using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchOrganizationRepositoriesWithAnalysis
    {
        [JsonProperty("names")]
        public List<string> Names { get; set; }
    }
}
