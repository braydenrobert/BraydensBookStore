using BraydensBooks.DataAccess.Respository.IRepository;
using BraydensBooks.DataAccess;
using Microsoft.AspNetCore.Mvc;
using BraydensBooks.Models;
using BraydensBooks.DataAccess.Respository;

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
