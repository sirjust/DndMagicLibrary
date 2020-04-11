using DndMagicLibrary.Data;
using DndMagicLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

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
                default: return null;
            }
        }
    }
}