using Elite.Data.Repository.IRepository;
using Elite.Models;
using Elite.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elite.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Product()
        {
            List<Product> products = _unitOfWork.product.GetAll(includeProperties: "Category").ToList();
           
            return View(products);
        }

        public IActionResult Upsert(int? id)
        {
            //ViewBag.categoryList = categoryList;
            ProductVM productVM = new()
            {
                categoryList = _unitOfWork.category.GetAll(includeProperties: "Category").Select(p => new SelectListItem
                {
                    Text = p.Name,
                    Value = p.ID.ToString()
                }),
                Product = new Product()
            };
            if (id is null || id <= 0)
            {
                return View(productVM); //create a new product
            }
            else
            {
                productVM.Product = _unitOfWork.product.Get(p => p.Id == id);
                return View(productVM); //update
            }
        }

        [HttpPost]
        public IActionResult Upsert(ProductVM cat, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, "Images", "Products");

                    if (!string.IsNullOrEmpty(cat.Product.ImageUrl))
                    {
                        string imagePath = Path.Combine(wwwRootPath, cat.Product.ImageUrl.TrimStart('/'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    cat.Product.ImageUrl = "/Images/Products/" + fileName;
                }
            }
            if(cat.Product.Id == 0)
            {
                _unitOfWork.product.Add(cat.Product);
            }
            else
            {
                _unitOfWork.product.Update(cat.Product);
            }
            _unitOfWork.Save();
            TempData["Message"] = "Product Created Successfully";
            return RedirectToAction("Product");
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Product> products = _unitOfWork.product.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = products });
        } 
        [HttpDelete]
        public IActionResult Delete(int? id) 
        {
            var toBeDeleted = _unitOfWork.product.Get(u=>u.Id == id);
            if (toBeDeleted == null)
            {
                return Json(new { success = false, message = "error while deleteing" });
            }
            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, toBeDeleted.ImageUrl.TrimStart('/'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }
            _unitOfWork.product.Remove(toBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true, message = "product has been deleted" });
        }
       
    }
}
