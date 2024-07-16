using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class SingleAccountUserImport
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("requestor")]
        public OrganizationImportResponseRequestor Requestor { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("user_count")]
        public int UserCount { get; set; }
        [JsonProperty("processed_user_count")]
        public int ProcessedUserCount { get; set; }
        [JsonProperty("added_user_count")]
        public int AddedUserCount { get; set; }
        [JsonProperty("updated_user_count")]
        public int UpdatedUserCount { get; set; }
        [JsonProperty("closed_user_count")]
        public int ClosedUserCount { get; set; }
        [JsonProperty("no_action_required_user_count")]
        public int NoActionRequiredUserCount { get; set; }
        [JsonProperty("error_count")]
        public int ErrorCount { get; set; }
        [JsonProperty("warning_count")]
        public int WarningCount { get; set; }
        [JsonProperty("invalid_column_headers")]
        public string InvalidColumnHeaders { get; set; }
        [JsonProperty("imports_not_found_or_not_available_for_accounts")]
        public string ImportsNotFoundOrNotAvailableForAccounts { get; set; }
        [JsonProperty("imports_failed_for_accounts")]
        public string ImportsFailedForAccounts { get; set; }
        [JsonProperty("imports_timed_out_for_accounts")]
        public string ImportsTimedOutForAccounts { get; set; }
        [JsonProperty("imports_not_found_or_not_available_for_sites")]
        public string ImportsNotFoundOrNotAvailableForSites { get; set; }
        [JsonProperty("imports_failed_for_sites")]
        public string ImportsFailedForSites { get; set; }
        [JsonProperty("imports_timed_out_for_sites")]
        public string ImportsTimedOutForSites { get; set; }
        [JsonProperty("file_level_error_rollups")]
        public List<OrganizationImportResponseErrorRollup> FileLevelErrorRollups { get; set; }
        [JsonProperty("user_level_error_rollups")]
        public List<OrganizationImportResponseErrorRollup> UserLevelErrorRollups { get; set; }
        [JsonProperty("user_level_warning_rollups")]
        public List<OrganizationImportResponseWarningRollup> UserLevelWarningRollups { get; set; }
        [JsonProperty("has_csv_results")]
        public bool HasCsvResults { get; set; }
        [JsonProperty("results_uri")]
        public string ResultsUri { get; set; }
    }
}
