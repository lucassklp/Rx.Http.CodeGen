using Newtonsoft.Json;

namespace Codacy.Models
{
    public class CreateCodingStandardPresetBody
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
        [JsonProperty("presets")]
        public CodingStandardCategoriesPresets Presets { get; set; }
    }
}
