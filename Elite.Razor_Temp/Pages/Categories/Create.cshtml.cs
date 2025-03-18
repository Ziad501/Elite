using Elite.Razor_Temp.Data;
using Elite.Razor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elite.Razor_Temp.Pages.Categories
{
    [BindProperties] //هيشغل الكاتيجوري مع ال بوست ميثود
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        //[BindProperty]
        public Category category { get; set; }
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            TempData["Message"] = "Category Created Successfully";
            return RedirectToPage("Index");
        }
    }
}
