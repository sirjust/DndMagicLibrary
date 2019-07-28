using System.Threading.Tasks;

namespace DndMagicLibrary.Models
{
    public interface IDndClass
    {
        string Description { get; set; }
        int Hit_Die { get; set; }
        int Index { get; set; }
        string Name { get; set; }
        SpellCasting SpellCasting { get; set; }

        Task<DndClass> GetClassData();
        Task<SpellCasting> GetSpellcastingData();
    }
}