using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmDashboardRepositoriesResponse
    {
        [JsonProperty("data")]
        public List<SrmRepositoryIssueCount> Data { get; set; }
    }
}
