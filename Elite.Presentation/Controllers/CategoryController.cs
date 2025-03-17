using Elite.Presentation.Data;
using Elite.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Elite.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Category()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult CreateCategory() => View();

        [HttpPost]
        public IActionResult SaveCategory(Category cat)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateCategory", cat);
            }
            if (cat.Name == cat.DisplayOrder.ToString())
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
                TempData["Message"] = "Category Created Successfully";
                return RedirectToAction("Category");
            }
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            Category? category = _context.Categories.FirstOrDefault(p => p.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult SaveEdit(Category cat)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(cat);
                _context.SaveChanges();
                TempData["Message"] = "Category Updated Successfully";
                return RedirectToAction("Category");
            }
            return View("Edit", cat);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            Category? category = _context.Categories.FirstOrDefault(p => p.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletPost(int? id)
        {
            Category cat = _context.Categories.FirstOrDefault(p => p.ID == id);
            if (cat == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(cat);
            _context.SaveChanges();
            TempData["Message"] = "Category Deleted Successfully";
            return RedirectToAction("Category");
        }
    }
}
