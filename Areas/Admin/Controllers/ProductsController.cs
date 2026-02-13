using KAShop.Data;
using KAShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KAShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var products = context.Products.Include(p=>p.Category).ToList();
            return View(products);
        }
        public IActionResult Create() {
            ViewData["categories"] = context.Categories.ToList();
            //or using viewbag : 
           // ViewBag.Categories = context.Categories.ToList();
            return View(new Product() { });
        }

        public IActionResult Store(Product req, IFormFile Image) {
            if (Image != null && Image.Length > 0 ) { 
                var fileName = Guid.NewGuid().ToString();
                fileName += Path.GetExtension(Image.FileName);

                var filePath= Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images",fileName);

                using(var stream = System.IO.File.Create(filePath))
                {
                    Image.CopyTo(stream);
                }
                req.Image = fileName;
                context.Products.Add(req);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return Content("ok");
        }
    }
}
