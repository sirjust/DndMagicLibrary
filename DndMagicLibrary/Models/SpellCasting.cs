using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Models
{
    public class SpellCasting
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        public Spellcasting_Ability SpellCasting_Ability { get; set; }
        public Spellcasting_Info Info { get; set; }
    }

    public class Spellcasting_Info
    {
        // there are many nested objects inside of spellcasting info
        // todo: find a way to parse them
    }

    public class Spellcasting_Ability
    {
        public string Url { get; set; }
        public string Name { get; set; }
    }
}