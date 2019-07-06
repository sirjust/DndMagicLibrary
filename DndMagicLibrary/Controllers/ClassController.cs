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

        public ActionResult Bard()
        {
            var bard = new DndClass { Name = "Bard" };
            return View(bard);
        }

        [HttpGet]
        public async Task<DndClass> GetData()
        {
            var url = "classes/2";
            DndClass dndClass = default;
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(ApiHelper.ApiClient.BaseAddress + url))
            {
                if (response.IsSuccessStatusCode)
                {
                    dndClass = await response.Content.ReadAsAsync<DndClass>();
                    return dndClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
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