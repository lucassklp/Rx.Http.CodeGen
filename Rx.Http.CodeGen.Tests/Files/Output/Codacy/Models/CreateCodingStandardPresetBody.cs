namespace Codacy.Models
{
    public class CreateCodingStandardPresetBody
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public CodingStandardCategoriesPresets Presets { get; set; }
    }
}
