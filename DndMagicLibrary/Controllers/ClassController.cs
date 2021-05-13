using DndMagicLibrary.Data;
using DndMagicLibrary.Data.Api;
using DndMagicLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DndMagicLibrary.Controllers
{
    [RoutePrefix("Class")]
    public class ClassController : Controller
    {
        IApiHelper _helper;
        public ClassController(IApiHelper helper)
        {
            _helper = helper;
        }

        public ActionResult Index()
        {
            return View();
        }

        [Route("/{id}")]
        public async Task<ActionResult> ShowClass(string id)
        {
            var dndClass = new DndClass(_helper, id);
            var newModel = await dndClass.GetClassData(dndClass);
            newModel.Spells = GetSpellNames(dndClass.Name);
            return View(newModel);
        }

        private Dictionary<int, IEnumerable<string>> GetSpellNames(string dndClass)
        {
            var spellList = new ClassSpellLists();
            switch (dndClass.ToLower())
            {
                case "bard": return spellList.GetBardSpells();
                case "cleric": return spellList.GetClericSpells();
                case "druid": return spellList.GetDruidSpells();
                case "paladin": return spellList.GetPaladinSpells();
                case "ranger": return spellList.GetRangerSpells();
                case "sorcerer": return spellList.GetSorcererSpells();
                case "warlock": return spellList.GetWarlockSpells();
                case "wizard": return spellList.GetWizardSpells();
                default: return null;

            }
        }
    }
}