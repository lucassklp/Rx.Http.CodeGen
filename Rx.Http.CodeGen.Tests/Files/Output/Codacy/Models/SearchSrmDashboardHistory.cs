using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchSrmDashboardHistory
    {
        [JsonProperty("repositories")]
        public List<string> Repositories { get; set; }
    }
}
