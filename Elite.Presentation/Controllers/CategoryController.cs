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
        public IActionResult Create()
        {
            return View();
        }
    }
}
