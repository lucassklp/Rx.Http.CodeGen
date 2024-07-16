using Newtonsoft.Json;

namespace DocuSign.Models
{
    public class PagingResponseProperties
    {
        [JsonProperty("result_set_size")]
        public int ResultSetSize { get; set; }
        [JsonProperty("result_set_start_position")]
        public int ResultSetStartPosition { get; set; }
        [JsonProperty("result_set_end_position")]
        public int ResultSetEndPosition { get; set; }
        [JsonProperty("total_set_size")]
        public int TotalSetSize { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
        [JsonProperty("previous")]
        public string Previous { get; set; }
    }
}
