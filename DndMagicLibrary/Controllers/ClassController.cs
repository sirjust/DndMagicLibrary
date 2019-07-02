using DndMagicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DndMagicLibrary.Controllers
{
    public class ClassController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bard()
        {
            var bard = new DndClass { ClassName = "Bard" };
            return View(bard);
        }

        public ActionResult Cleric()
        {
            return View();
        }

        public ActionResult Druid()
        {
            return View();
        }

        public ActionResult Paladin()
        {
            return View();
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