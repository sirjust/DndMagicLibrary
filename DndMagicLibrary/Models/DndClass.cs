using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Models
{
    public class DndClass
    {
        public string ClassName { get; set; }
        public string Description { get; set; }
        public string HitDice { get; set; }
        public List<string> Proficiencies { get; set; }
        public List<string> SubClasses { get; set; }
    }
}