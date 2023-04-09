using Microsoft.AspNetCore.Mvc;
using Project.BLL.AbstractService;
using Project.Entity.Entity;
using Project.MVC.Areas.Dashboard.ViewModels;
using System.Linq;

namespace Project.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View(_categoryService.GetAllCategory().ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryVM categoryVM)
        {
            Category category = new Category
            {
                CategoryName = categoryVM.CategoryName,
                Description = categoryVM.Description
            };
            
            TempData["result"] = _categoryService.CreateCategory(category);
            return RedirectToAction("Index");
        }
    }
}
