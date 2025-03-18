using Elite.Razor_Temp.Data;
using Elite.Razor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elite.Razor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Category? category { get; set; }
        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            if(id is not null || id !<= 0)
            category = _context.Categories.FirstOrDefault(p => p.ID == id);
        }
        public IActionResult OnPost() 
        {
            Category? cat = _context.Categories.FirstOrDefault(p => p.ID == category.ID);
            if(cat == null)
                return NotFound();
            _context.Categories.Remove(cat);
            _context.SaveChanges();
            TempData["Message"] = "Category Deleted Successfully";
            return RedirectToPage("Index");
        }
    }
}
