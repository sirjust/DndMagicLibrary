using DndMagicLibrary.Data;
using System.Web.Mvc;

namespace DndMagicLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(AllClasses.DndClasses);
        }
    }
}