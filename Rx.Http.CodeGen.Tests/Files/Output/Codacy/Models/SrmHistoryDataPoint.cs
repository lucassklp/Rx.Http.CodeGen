using Newtonsoft.Json;

namespace Codacy.Models
{
    public class SrmHistoryDataPoint
    {
        [JsonProperty("since")]
        public string Since { get; set; }
        [JsonProperty("until")]
        public string Until { get; set; }
        [JsonProperty("newCritical")]
        public int NewCritical { get; set; }
        [JsonProperty("newHigh")]
        public int NewHigh { get; set; }
        [JsonProperty("newMedium")]
        public int NewMedium { get; set; }
        [JsonProperty("newLow")]
        public int NewLow { get; set; }
        [JsonProperty("fixedCritical")]
        public int FixedCritical { get; set; }
        [JsonProperty("fixedHigh")]
        public int FixedHigh { get; set; }
        [JsonProperty("fixedMedium")]
        public int FixedMedium { get; set; }
        [JsonProperty("fixedLow")]
        public int FixedLow { get; set; }
        [JsonProperty("openCritical")]
        public int OpenCritical { get; set; }
        [JsonProperty("openHigh")]
        public int OpenHigh { get; set; }
        [JsonProperty("openMedium")]
        public int OpenMedium { get; set; }
        [JsonProperty("openLow")]
        public int OpenLow { get; set; }
    }
}
