using DndMagicLibrary.Data;
using DndMagicLibrary.Data.Api;
using System.Web.Mvc;

namespace DndMagicLibrary.Controllers
{
    public class HomeController : Controller
    {
        AllClasses _allClasses;

        public HomeController(IApiHelper helper)
        {
            _allClasses = new AllClasses(helper);
        }

        public ActionResult Index()
        {
            return View(_allClasses.GetDndClasses());
        }
    }
}