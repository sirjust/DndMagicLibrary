using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Models
{
    public class SpellcastingObject
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        public Spellcasting_Ability Spellcasting_Ability { get; set; }
    }

    public class Spellcasting_Ability
    {
        public string Name { get; set; }
    }
}