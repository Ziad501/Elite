using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Elite.Models;
using Elite.Data.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace Elite.Presentation.Areas.Customer.Controllers;
[Area("Customer")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;
    public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        IEnumerable<Product> productList = _unitOfWork.product.GetAll(includeProperties: "Category");

        return View(productList);
    } 
    public IActionResult Details(int? id)
    {
        ShoppingCart cart = new()
        {
            Product = _unitOfWork.product.Get(p => p.Id == id),
            Count = 1,
            ProductId = id

        };
        return View(cart);
    }
    [HttpPost]
    [Authorize]
    public IActionResult Details(ShoppingCart shoppingCart)
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

        shoppingCart.ApplicationUserId = userId;
        shoppingCart.Id = 0; 

        ShoppingCart? cartFromDb =_unitOfWork.shoppingCart.Get(p=>p.ApplicationUserId == userId && p.ProductId == shoppingCart.ProductId);
        if (cartFromDb != null)
        {
            cartFromDb.Count += shoppingCart.Count;
            _unitOfWork.shoppingCart.Update(cartFromDb);
        }
        else
        {
            _unitOfWork.shoppingCart.Add(shoppingCart);
        }
        _unitOfWork.Save();

        return RedirectToAction(nameof(Index));
    }



    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
}
