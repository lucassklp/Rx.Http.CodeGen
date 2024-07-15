using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("itemSource")]
        public string ItemSource { get; set; }
        [JsonProperty("itemSourceId")]
        public string ItemSourceId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("repository")]
        public string Repository { get; set; }
        [JsonProperty("openedAt")]
        public string OpenedAt { get; set; }
        [JsonProperty("closedAt")]
        public string ClosedAt { get; set; }
        [JsonProperty("dueAt")]
        public string DueAt { get; set; }
        [JsonProperty("priority")]
        public string Priority { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("htmlUrl")]
        public string HtmlUrl { get; set; }
        [JsonProperty("projectKey")]
        public string ProjectKey { get; set; }
        [JsonProperty("securityCategory")]
        public string SecurityCategory { get; set; }
        [JsonProperty("scanType")]
        public string ScanType { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("cvssScore")]
        public float CvssScore { get; set; }
        [JsonProperty("cvssVector")]
        public string CvssVector { get; set; }
        [JsonProperty("cwe")]
        public string Cwe { get; set; }
        [JsonProperty("affectedTargets")]
        public string AffectedTargets { get; set; }
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
        [JsonProperty("likelihood")]
        public string Likelihood { get; set; }
        [JsonProperty("effortToFix")]
        public string EffortToFix { get; set; }
        [JsonProperty("remediation")]
        public string Remediation { get; set; }
    }
}
