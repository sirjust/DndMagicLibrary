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

        [Route("/{id}")]
        public async Task<ActionResult> ShowClass(string id)
        {
            var dndClass = new DndClass(id);
            var newModel = await dndClass.GetClassData(dndClass);
            return View(newModel);
        }
    }
}