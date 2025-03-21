using Elite.Data.Repository.IRepository;
using Elite.Models;
using Elite.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Elite.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Category()
        {
            List<Category> categories = _unitOfWork.category.GetAll().ToList();
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

            if (_unitOfWork.category.Any(c => c.Name == cat.Name))
            {
                ModelState.AddModelError("Name", "Category Name already exists.");
                return View("CreateCategory", cat);
            }

            if (_unitOfWork.category.Any(p => p.DisplayOrder == cat.DisplayOrder))
            {
                ModelState.AddModelError("DisplayOrder", "Display Order is required and must be unique.");
                return View("CreateCategory", cat);
            }

            _unitOfWork.category.Add(cat);
            _unitOfWork.Save();
            TempData["Message"] = "Category Created Successfully";
            return RedirectToAction("Category");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            Category? category = _unitOfWork.category.Get(p => p.ID == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult SaveEdit(Category cat)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", cat);
            }

            if (_unitOfWork.category.Any(c => c.Name == cat.Name && c.ID != cat.ID))
            {
                ModelState.AddModelError("Name", "Category Name already exists.");
                return View("Edit", cat);
            }

            _unitOfWork.category.Update(cat);
            _unitOfWork.Save();
            TempData["Message"] = "Category Updated Successfully";
            return RedirectToAction("Category");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            Category? category = _unitOfWork.category.Get(p => p.ID == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletPost(int? id)
        {
            Category? cat = _unitOfWork.category.Get(p => p.ID == id);
            if (cat == null)
            {
                return NotFound();
            }

            _unitOfWork.category.Remove(cat);
            _unitOfWork.Save();
            TempData["Message"] = "Category Deleted Successfully";
            return RedirectToAction("Category");
        }
    }
}
