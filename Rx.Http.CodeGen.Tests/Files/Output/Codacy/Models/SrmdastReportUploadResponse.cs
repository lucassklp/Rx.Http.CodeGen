using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmdastReportUploadResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
