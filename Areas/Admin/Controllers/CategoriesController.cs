using KAShop.Data;
using KAShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace KAShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid)
            {
                var category = context.Categories.Add(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
           return View("create", request);

        }
        public IActionResult Remove(int id)
        {
            var categories = context.Categories.Find(id);
            context.Categories.Remove(categories);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);
        }

        public IActionResult Update(Category request, int id)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Update(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Edit",request);
        }
    }
}
