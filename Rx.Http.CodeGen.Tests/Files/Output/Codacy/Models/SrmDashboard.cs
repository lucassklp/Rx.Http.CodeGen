namespace Codacy.Models
{
    public class SrmDashboard
    {
        public int TotalOpen { get; set; }
        public int TotalClosed { get; set; }
        public int OnTrack { get; set; }
        public int DueSoon { get; set; }
        public int Overdue { get; set; }
        public int ClosedOnTime { get; set; }
        public int ClosedLate { get; set; }
        public int OpenCritical { get; set; }
        public int OpenHigh { get; set; }
        public int OpenMedium { get; set; }
        public int OpenLow { get; set; }
        public int OpenSast { get; set; }
        public int OpenSca { get; set; }
        public int OpenContainerSca { get; set; }
        public int OpenSecrets { get; set; }
        public int OpenIaC { get; set; }
        public int OpenCicd { get; set; }
        public int OpenLicense { get; set; }
        public int OpenPenTesting { get; set; }
        public int OpenDast { get; set; }
        public int OpenCspm { get; set; }
        public int OpenScanNotAttributed { get; set; }
    }
}
