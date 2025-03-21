using Elite.Data.Repository.IRepository;
using Elite.Models;
using Elite.Models.ViewModels;
using Elite.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elite.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Company()
        {
            List<Company> Companys = _unitOfWork.company.GetAll().ToList();

            return View();
        }

        public IActionResult Upsert(int? id)
        {

            if (id is null || id <= 0)
            {
                return View(new Company()); //create a new Company
            }
            else
            {
                Company com = _unitOfWork.company.Get(p => p.Id == id);
                return View(com); //update
            }
        }

        [HttpPost]
        public IActionResult Upsert(Company com, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                if (com.Id == 0)
                {
                    _unitOfWork.company.Add(com);
                }
                else
                {
                    _unitOfWork.company.Update(com);
                }
                _unitOfWork.Save();
                TempData["Message"] = "Company Created Successfully";
                return RedirectToAction("Company");
            }
            else
            {
                return View(com);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var companies = _unitOfWork.company.GetAll().ToList();

            return Json(new { data = companies });
        }
        [HttpDelete]
        public IActionResult Delete(int? id) 
        {
            var toBeDeleted = _unitOfWork.company.Get(u=>u.Id == id);
            if (toBeDeleted == null)
            {
                return Json(new { success = false, message = "error while deleteing" });
            }
            _unitOfWork.company.Remove(toBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Company has been deleted" });
        }
       
    }
}
