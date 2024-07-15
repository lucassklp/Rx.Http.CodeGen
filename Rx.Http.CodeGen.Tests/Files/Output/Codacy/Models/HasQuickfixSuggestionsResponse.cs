using Newtonsoft.Json;

namespace Codacy.Models
{
    public class HasQuickfixSuggestionsResponse
    {
        [JsonProperty("hasSuggestions")]
        public bool HasSuggestions { get; set; }
    }
}
