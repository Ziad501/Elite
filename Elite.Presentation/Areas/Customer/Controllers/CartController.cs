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
        public CartController(IUnitOfWork unitOfWork)
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
        public IActionResult Summery()
        {
            return View();
        }

        public IActionResult Plus(int id)
        {
            var cartFromDb = _unitOfWork.shoppingCart.Get(p => p.Id == id);
            cartFromDb.Count += 1;
            _unitOfWork.shoppingCart.Update(cartFromDb);
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Minus(int id)
        {
            var cartFromDb = _unitOfWork.shoppingCart.Get(p => p.Id == id);
            if (cartFromDb.Count <= 1)
            {
                _unitOfWork.shoppingCart.Remove(cartFromDb);
            }
            else
            {
                cartFromDb.Count -= 1;
                _unitOfWork.shoppingCart.Update(cartFromDb);
            }
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Remove(int id)
        {
            var cartFromDb = _unitOfWork.shoppingCart.Get(p => p.Id == id);
            _unitOfWork.shoppingCart.Remove(cartFromDb);
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }


        private double GetPricePerQuantity(ShoppingCart shoppingCart)
        {
            if (shoppingCart.Count <= 50)
            {
                return shoppingCart.Product.Price;
            }
            else
            {
                if (shoppingCart.Count <= 100)
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
