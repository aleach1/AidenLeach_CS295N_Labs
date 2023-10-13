using Microsoft.AspNetCore.Mvc;

namespace AllAboutWillWood.Controllers
{
    public class MerchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
