using Newtonsoft.Json;

namespace Codacy.Models
{
    public class RepositoryResponse
    {
        [JsonProperty("data")]
        public Repository Data { get; set; }
    }
}
