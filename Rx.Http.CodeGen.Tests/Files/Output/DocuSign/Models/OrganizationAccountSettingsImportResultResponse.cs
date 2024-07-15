using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrganizationAccountSettingsImportResultResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("site_id")]
        public int SiteId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("number_processed_accounts")]
        public int NumberProcessedAccounts { get; set; }
        [JsonProperty("error_details")]
        public OasirrErrorDetails ErrorDetails { get; set; }
        [JsonProperty("processing_issues_by_account")]
        public List<OasirrOrganizationAccountSettingsErrorDataResponse> ProcessingIssuesByAccount { get; set; }
        [JsonProperty("number_unprocessed_accounts")]
        public int NumberUnprocessedAccounts { get; set; }
    }
}
