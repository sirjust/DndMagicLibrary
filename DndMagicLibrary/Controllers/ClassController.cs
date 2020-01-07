using DndMagicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using DndMagicLibrary.Helpers;
using System.Threading.Tasks;
using DndMagicLibrary.Data;

namespace DndMagicLibrary.Controllers
{
    [RoutePrefix("Class")]
    public class ClassController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("/{model.Name}")]
        public async Task<ActionResult> GetDndClass(DndClass model)
        {
            var newModel = await model.GetClassData(model);
            return View(newModel);
        }

        //public async Task<ActionResult> Bard()
        //{
        //    var bardParam = new DndClass("Bard", Descriptions.DescriptionsDictionary["Bard"], 2, 1);
        //    var bard = await bardParam.GetClassData(bardParam);
        //    return View(bard);
        //}

        //public async Task<ActionResult> Cleric()
        //{
        //    var clericParam = new DndClass("Cleric", Descriptions.DescriptionsDictionary["Cleric"], 3, 2);
        //    var cleric = await clericParam.GetClassData(clericParam);
        //    return View(cleric);
        //}

        //public async Task<ActionResult> Druid()
        //{
        //    var druidParam = new DndClass("Druid", Descriptions.DescriptionsDictionary["Druid"], 4, 3);
        //    var druid = await druidParam.GetClassData(druidParam);
        //    return View(druid);
        //}

        //public async Task<ActionResult> Paladin()
        //{
            //var paladin = new DndClass { Name = "Paladin", Index = 7 };
            //paladin = await paladin.GetClassData();
            //return View(paladin);
        //}

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