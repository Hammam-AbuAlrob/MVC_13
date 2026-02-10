using Microsoft.AspNetCore.Mvc;

namespace KAShop.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
          //  return Content("this is home for user ");
        }
    }
}
