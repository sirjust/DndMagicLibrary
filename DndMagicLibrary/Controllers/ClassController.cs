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
            var bard = await GetClassData(bardParam);
            return View(bard);
        }

        public async Task<ActionResult> Cleric()
        {
            var clericParam = new DndClass { Name = "Cleric", Index = 3 };
            var cleric = await GetClassData(clericParam);
            return View(cleric);
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

        [HttpGet]
        public async Task<DndClass> GetClassData(DndClass dndClassParam)
        {
            var url = $"classes/{dndClassParam.Index}";
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

        [HttpGet]
        public async Task<Spellcasting_Ability> GetSpellcastingData()
        {
            string url = "http://www.dnd5eapi.co/api/spellcasting/1";
            var spellCastingAbility = new Spellcasting_Ability();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    spellCastingAbility = await response.Content.ReadAsAsync<Spellcasting_Ability>();
                    return spellCastingAbility;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}