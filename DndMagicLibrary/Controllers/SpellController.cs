using DndMagicLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DndMagicLibrary.Controllers
{
    public class SpellController : Controller
    {
        // GET: Spell
        [Route("/{id}")]
        public ActionResult Spell(int id)
        {
            int level = id;
            var model = new SpellViewModel
            {
                ClassName = "Bard",
                Spells = Data.SpellsKnown.GetSpells("Bard")
            };
            return View(model);
        }
    }
}