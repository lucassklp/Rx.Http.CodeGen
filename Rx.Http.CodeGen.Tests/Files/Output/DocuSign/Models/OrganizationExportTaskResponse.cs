using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationExportTaskResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("number_rows")]
        public int NumberRows { get; set; }
        [JsonProperty("size_bytes")]
        public int SizeBytes { get; set; }
        [JsonProperty("error_details")]
        public OetrErrorDetails ErrorDetails { get; set; }
    }
}
