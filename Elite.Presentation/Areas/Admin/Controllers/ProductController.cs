using Elite.Data.Repository.IRepository;
using Elite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Elite.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Product()
        {
            List<Product> products = _unitOfWork.product.GetAll().ToList();
            return View(products);
        }

        public IActionResult CreateProduct() => View();

        [HttpPost]
        public IActionResult SaveProduct(Product cat)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.product.Add(cat);
                _unitOfWork.Save();
                TempData["Message"] = "Product Created Successfully";
                return RedirectToAction("Product");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            Product? Product = _unitOfWork.product.Get(p => p.Id == id);
            if (Product == null)
            {
                return NotFound();
            }

            return View(Product);
        }

        [HttpPost]
        public IActionResult SaveEdit(Product cat)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.product.Update(cat);
                _unitOfWork.Save();
                TempData["Message"] = "Product Updated Successfully";
                return RedirectToAction("Product");
            }
            return View(cat);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            Product? Product = _unitOfWork.product.Get(p => p.Id == id);
            if (Product == null)
            {
                return NotFound();
            }

            return View(Product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletPost(int? id)
        {
            Product? cat = _unitOfWork.product.Get(p => p.Id == id);
            if (cat == null)
            {
                return NotFound();
            }

            _unitOfWork.product.Remove(cat);
            _unitOfWork.Save();
            TempData["Message"] = "Product Deleted Successfully";
            return RedirectToAction("Product");
        }
    }
}
