using DndMagicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DndMagicLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Overview overview = new Overview();
            overview.Classes = overview.GetDndClasses();
            return View(overview);
        }

        public ViewResult FindClass()
        {
            return View();
        }
    }
}