using Elite.Presentation.Data;
using Elite.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Elite.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext Context)
        {
            _context = Context;
        }
        public IActionResult Category()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        public IActionResult CreateCategory() => View("CreateCategory");
        [HttpPost]
        public IActionResult SaveCategory(Category cat)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateCategory", cat);
            }
            if(cat.Name == cat.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Category Name and Display Order cannot be the same.");
                return View("CreateCategory", cat);
            }
            if (_context.Categories.Any(c => c.Name == cat.Name))
            {
                ModelState.AddModelError("Name", "Category Name already exists");
                return View("CreateCategory", cat);
            }
            if (_context.Categories.Any(p => p.DisplayOrder == cat.DisplayOrder))
            {
                ModelState.AddModelError("DisplayOrder", "Display Order is required and must be unique.");
                return View("CreateCategory", cat);
            }
            else
            {
                _context.Categories.Add(cat);
                _context.SaveChanges();
                return RedirectToAction("Category", cat);
            }
        }
    }
}
