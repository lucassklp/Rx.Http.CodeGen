using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OrgReportConfigurationResponse
    {
        [JsonProperty("is_account_limit_disabled")]
        public bool IsAccountLimitDisabled { get; set; }
        [JsonProperty("custom_dates_enabled")]
        public bool CustomDatesEnabled { get; set; }
        [JsonProperty("enabled_report_types")]
        public List<int> EnabledReportTypes { get; set; }
    }
}
