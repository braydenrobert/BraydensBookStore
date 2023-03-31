using BraydensBooks.DataAccess.Respository.IRepository;
using BraydensBooks.DataAccess;
using Microsoft.AspNetCore.Mvc;
using BraydensBooks.Models;
using BraydensBooks.DataAccess.Respository;
using Microsoft.EntityFrameworkCore;
using BraydensBookStore.DataAcccess.Data;

namespace BraydensBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }


        public IActionResult Index()
        {
            return View();
        }

        // use HTTP Post to define the post-action method
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if(ModelState.IsValid) // checks all validations in the model (e.g. Name Required) to increase security
            {
                if(category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            } 
            return View(category);
        }

        // API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
