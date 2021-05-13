using Newtonsoft.Json;

namespace DndMagicLibrary.Models
{
    public class SpellCasting
    {
        public string Url { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        [JsonProperty("spellcasting_ability")]
        public SpellcastingAbility SpellcastingAbility { get; set; }
    }
}