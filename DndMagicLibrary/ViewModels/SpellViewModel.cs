using DndMagicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.ViewModels
{
    public class SpellViewModel
    {
        public string ClassName { get; set; }
        public List<List<Spell>> Spells { get; set; }
    }
}