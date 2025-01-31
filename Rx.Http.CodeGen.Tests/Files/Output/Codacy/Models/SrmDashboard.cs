using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmDashboard
    {
        [JsonProperty("totalOpen")]
        public int TotalOpen { get; set; }
        [JsonProperty("totalNewThisWeek")]
        public int TotalNewThisWeek { get; set; }
        [JsonProperty("totalClosed")]
        public int TotalClosed { get; set; }
        [JsonProperty("onTrack")]
        public int OnTrack { get; set; }
        [JsonProperty("dueSoon")]
        public int DueSoon { get; set; }
        [JsonProperty("overdue")]
        public int Overdue { get; set; }
        [JsonProperty("closedOnTime")]
        public int ClosedOnTime { get; set; }
        [JsonProperty("closedLate")]
        public int ClosedLate { get; set; }
        [JsonProperty("openCritical")]
        public int OpenCritical { get; set; }
        [JsonProperty("openHigh")]
        public int OpenHigh { get; set; }
        [JsonProperty("openMedium")]
        public int OpenMedium { get; set; }
        [JsonProperty("openLow")]
        public int OpenLow { get; set; }
        [JsonProperty("openSAST")]
        public int OpenSast { get; set; }
        [JsonProperty("openSCA")]
        public int OpenSca { get; set; }
        [JsonProperty("openContainerSCA")]
        public int OpenContainerSca { get; set; }
        [JsonProperty("openSecrets")]
        public int OpenSecrets { get; set; }
        [JsonProperty("openIaC")]
        public int OpenIaC { get; set; }
        [JsonProperty("openCICD")]
        public int OpenCicd { get; set; }
        [JsonProperty("openLicense")]
        public int OpenLicense { get; set; }
        [JsonProperty("openPenTesting")]
        public int OpenPenTesting { get; set; }
        [JsonProperty("openDAST")]
        public int OpenDast { get; set; }
        [JsonProperty("openCSPM")]
        public int OpenCspm { get; set; }
        [JsonProperty("openScanNotAttributed")]
        public int OpenScanNotAttributed { get; set; }
    }
}
