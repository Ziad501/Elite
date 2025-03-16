using Microsoft.AspNetCore.Mvc;

namespace Elite.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Category()
        {
            return View();
        }
    }
}
