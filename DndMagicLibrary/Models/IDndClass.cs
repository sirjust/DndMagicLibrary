using System.Collections.Generic;
using System.Threading.Tasks;

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
        List<List<Spell>> Spells { get; set; }

        Task<DndClass> GetClassData(DndClass dndClass);
        Task<SpellCasting> GetSpellcastingData();
    }
}