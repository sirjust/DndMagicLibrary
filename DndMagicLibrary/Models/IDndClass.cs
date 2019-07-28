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
        Spellcasting_Ability SpellCasting_Ability { get; set; }
        string SpellcastingUrl { get; set; }

        Task<DndClass> GetClassData();
        Task<SpellCasting> GetSpellcastingData(int index);
        Task<string> GetSpellcastingUrl();
    }
}