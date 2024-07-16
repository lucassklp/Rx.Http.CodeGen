using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryWithAnalysisResponse
    {
        [JsonProperty("data")]
        public RepositoryWithAnalysis Data { get; set; }
    }
}
