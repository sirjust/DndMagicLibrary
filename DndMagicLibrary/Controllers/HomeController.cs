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
            return View(Helpers.AllClasses.DndClasses);
        }

        //public ViewResult FindClass()
        //{
        //    return View();
        //}
    }
}