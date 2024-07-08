namespace DocuSign.Models
{
    public class OrgReportConfigurationResponse
    {
        public bool IsAccountLimitDisabled { get; set; }
        public bool CustomDatesEnabled { get; set; }
        public List<int> EnabledReportTypes { get; set; }
    }
}
