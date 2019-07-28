namespace DndMagicLibrary.Models
{
    public interface ISpell
    {
        string Description { get; set; }
        string HigherLevelInfo { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        string Range { get; set; }
        SpellSchool SpellSchool { get; set; }
        string Url { get; set; }
    }
}