using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationAccountSettingsImportResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }
        [JsonProperty("completed")]
        public string Completed { get; set; }
        [JsonProperty("expires")]
        public string Expires { get; set; }
        [JsonProperty("percent_completed")]
        public int PercentCompleted { get; set; }
        [JsonProperty("number_processed_accounts")]
        public int NumberProcessedAccounts { get; set; }
        [JsonProperty("number_unprocessed_accounts")]
        public int NumberUnprocessedAccounts { get; set; }
        [JsonProperty("results")]
        public List<OrganizationAccountSettingsImportResultResponse> Results { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("skipped_settings_by_account")]
        public object SkippedSettingsByAccount { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("requestor")]
        public OrganizationAccountSettingsImportRequestorResponse Requestor { get; set; }
    }
}
