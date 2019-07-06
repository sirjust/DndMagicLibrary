using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Models
{
    public class DndClass
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
        public int Hit_Die { get; set; }
        public SpellcastingObject SpellcastingData { get; set; } = new SpellcastingObject();
    }
}