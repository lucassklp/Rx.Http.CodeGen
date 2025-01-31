using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SearchRepositoriesOfSbomDependencyBody
    {
        [JsonProperty("dependencyFullName")]
        public string DependencyFullName { get; set; }
    }
}
