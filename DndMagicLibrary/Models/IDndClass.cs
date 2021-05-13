using System.Collections.Generic;

namespace DndMagicLibrary.Models
{
    public interface IDndClass
    {
        int GeneralIndex { get; set; }
        int SpellcastingIndex { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Hit_Die { get; set; }
        SpellCasting SpellCasting { get; set; }
        Dictionary<int, IEnumerable<string>> Spells { get; set; }
    }
}