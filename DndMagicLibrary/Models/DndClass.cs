using DndMagicLibrary.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DndMagicLibrary.Models
{
    public class DndClass : IDndClass
    {
        public DndClass() { }

        public string Name { get; set; }
        public int GeneralIndex { get; set; }
        public int SpellcastingIndex { get; set; }
        public string Description { get; set; }
        public int Hit_Die { get; set; }
        [JsonProperty("spellcasting")]
        public SpellCasting SpellCasting { get; set; }

        [JsonIgnore]
        public Dictionary<int, IEnumerable<string>> Spells { get; set; }

        public DndClass(string name)
        {
            Name = name;
            Description = AllClasses.DndClasses.Where(x => x.Name == name).FirstOrDefault().Description;
            GeneralIndex = AllClasses.DndClasses.Where(x => x.Name == name).FirstOrDefault().GeneralIndex;
            SpellcastingIndex = AllClasses.DndClasses.Where(x => x.Name == name).FirstOrDefault().SpellcastingIndex;
        }

        public DndClass(string name, string description, int generalIndex, int spellcastingIndex)
        {
            Name = name;
            Description = description;
            GeneralIndex = generalIndex;
            SpellcastingIndex = spellcastingIndex;
        }
    }
}