using Microsoft.AspNetCore.Mvc;

namespace KAShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("this is admin home");

            //return View("Index")
            //or return View();
            return View("Index");
        }
    }
}
