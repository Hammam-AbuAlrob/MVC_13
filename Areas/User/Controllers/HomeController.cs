using KAShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace KAShop.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();


        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
          //  return Content("this is home for user ");
        }
    }
}
