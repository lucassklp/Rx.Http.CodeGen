using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationExportResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("requestor")]
        public OrganizationExportRequestorResponse Requestor { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }
        [JsonProperty("completed")]
        public string Completed { get; set; }
        [JsonProperty("expires")]
        public string Expires { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("selected_accounts")]
        public List<OrgExportSelectedAccount> SelectedAccounts { get; set; }
        [JsonProperty("selected_domains")]
        public List<OrgExportSelectedDomain> SelectedDomains { get; set; }
        [JsonProperty("metadata_url")]
        public string MetadataUrl { get; set; }
        [JsonProperty("percent_completed")]
        public int PercentCompleted { get; set; }
        [JsonProperty("number_rows")]
        public int NumberRows { get; set; }
        [JsonProperty("size_bytes")]
        public int SizeBytes { get; set; }
        [JsonProperty("results")]
        public List<OrganizationExportTaskResponse> Results { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
