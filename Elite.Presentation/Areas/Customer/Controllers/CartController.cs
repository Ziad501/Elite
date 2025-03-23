using Elite.Data.Repository.IRepository;
using Elite.Models;
using Elite.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Elite.Presentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCartVM shoppingCartVM { get; set; }
        public CartController (IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCartVM = new()
            {
                shoppingCarts = _unitOfWork.shoppingCart.GetAll(p => p.ApplicationUserId == userId, includeProperties: "Product")
            };
            foreach (var cart in shoppingCartVM.shoppingCarts)
            {
                cart.Price = GetPricePerQuantity(cart);
                shoppingCartVM.TotalOrder += (cart.Price * cart.Count);
            }
            return View(shoppingCartVM);
        }
        private double GetPricePerQuantity(ShoppingCart shoppingCart)
        {
            if (shoppingCart.Count <= 50)
            {
                return shoppingCart.Product.Price;
            }
            else
            {
                if(shoppingCart.Count<=100)
                {
                    return shoppingCart.Product.Price50;
                }
                else
                {
                    return shoppingCart.Product.Price100;
                }
            }

        }
    }
}
