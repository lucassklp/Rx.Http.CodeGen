using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchSrmDashboardRepositories
    {
        [JsonProperty("repositories")]
        public List<string> Repositories { get; set; }
        [JsonProperty("segments")]
        public List<int> Segments { get; set; }
    }
}
