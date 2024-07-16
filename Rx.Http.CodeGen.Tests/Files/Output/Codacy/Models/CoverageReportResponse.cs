using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CoverageReportResponse
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
