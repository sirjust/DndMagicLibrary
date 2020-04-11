using DndMagicLibrary.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DndMagicLibrary.Controllers
{
    public class SpellController : Controller
    {
        // GET: Spell
        [Route("/{id}")]
        public async Task<ActionResult> Spell(string id)
        {
            var spell = new Spell { Name = id };
            var apiName = spell.ConvertSpellName(id);
            return View(await spell.GetSpellData(apiName));
        }
    }
}