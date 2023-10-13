using Microsoft.AspNetCore.Mvc;

namespace AllAboutWillWood.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FanSites()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }
    }
}
