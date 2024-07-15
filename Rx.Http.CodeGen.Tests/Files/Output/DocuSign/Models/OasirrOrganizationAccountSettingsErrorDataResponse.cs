using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class OasirrOrganizationAccountSettingsErrorDataResponse
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("error_key")]
        public string ErrorKey { get; set; }
        [JsonProperty("setting_key")]
        public string SettingKey { get; set; }
    }
}
