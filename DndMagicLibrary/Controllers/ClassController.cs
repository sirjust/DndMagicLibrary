using DndMagicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using DndMagicLibrary.Helpers;
using System.Threading.Tasks;

namespace DndMagicLibrary.Controllers
{
    public class ClassController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Bard()
        {
            var bardParam = new DndClass { Name = "Bard", Index = 2 };
            var bard = await bardParam.GetClassData();
            // bard.SpellCasting.SetSpellcastingAbility();
            return View(bard);
        }

        public async Task<ActionResult> Cleric()
        {
            var clericParam = new DndClass { Name = "Cleric", Index = 3 };
            var cleric = await clericParam.GetClassData();
            return View(cleric);
        }

        public async Task<ActionResult> Druid()
        {
            var druid = new DndClass { Name = "Druid", Index = 4 };
            druid = await druid.GetClassData();
            return View(druid);
        }

        public async Task<ActionResult> Paladin()
        {
            var paladin = new DndClass { Name = "Paladin", Index = 7 };
            paladin = await paladin.GetClassData();
            return View(paladin);
        }

        public ActionResult Ranger()
        {
            return View();
        }

        public ActionResult Sorcerer()
        {
            return View();
        }

        public ActionResult Warlock()
        {
            return View();
        }
    }
}