using GAtec.Northwind.Business;
using GAtec.Northwind.Data;
using GAtec.Northwind.Domain.Business;
using GAtec.Northwind.Domain.Model;
using GAtec.Northwind.Util.Validation;
using System.Web.Mvc;

namespace GAtec.Northwind.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult IndexAsync()
        {
            var data = _categoryService.GetCategories();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CategoryDropDownList()
        {
            var data = _categoryService.GetCategories();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Category category)
        {
            // call the 
            if (_categoryService.Add(category))
            {
                return RedirectToAction("Index");
            }
            
            // transform default validator in model state
            foreach (var key in _categoryService.Validator.GetErrors())
            {
                foreach (var errorMessage in key.Value)
                {
                    ModelState.AddModelError(key.Key, errorMessage);
                }
            }

            return View(category);
        }

    }
}