using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Models
{
    public class Spell
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public List<DndClass> UsingClasses { get; set; }
        public string HigherLevelInfo { get; set; }
        public string Range { get; set; }
        public int MyProperty { get; set; }
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