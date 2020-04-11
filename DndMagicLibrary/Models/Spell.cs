namespace DndMagicLibrary.Models
{
    public class Spell : ISpell
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string HigherLevelInfo { get; set; }
        public string Range { get; set; }
        public SpellSchool SpellSchool { get; set; }
    }

    public enum SpellSchool
    {
        Abjuration,
        Conjuration,
        Divination,
        Enchantment,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation
    }
}