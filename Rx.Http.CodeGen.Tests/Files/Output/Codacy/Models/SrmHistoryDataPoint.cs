namespace Codacy.Models
{
    public class SrmHistoryDataPoint
    {
        public string Since { get; set; }
        public string Until { get; set; }
        public int NewCritical { get; set; }
        public int NewHigh { get; set; }
        public int NewMedium { get; set; }
        public int NewLow { get; set; }
        public int FixedCritical { get; set; }
        public int FixedHigh { get; set; }
        public int FixedMedium { get; set; }
        public int FixedLow { get; set; }
        public int OpenCritical { get; set; }
        public int OpenHigh { get; set; }
        public int OpenMedium { get; set; }
        public int OpenLow { get; set; }
    }
}
