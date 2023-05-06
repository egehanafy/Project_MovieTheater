using Microsoft.AspNetCore.Mvc;
using Project.BLL.IntService;
using Project.Entity.Entity;
using Project.MVC.Areas.Dashboard.ViewModels;
using System.Linq;

namespace Project.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HallController : Controller
    {
        private IHallService _hallService;

        public HallController(IHallService hallService)
        {
            _hallService = hallService;
        }

        public IActionResult Index()
        {
            return View(_hallService.GetAllHalls().ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HallVM hallVM)
        {
            Hall hall = new Hall
            {
                No = hallVM.HallName
            };

            TempData["result"] = _hallService.CreateHall(hall);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _hallService.GetById(id);

            if (deleted != null)
            {
                TempData["result"] = _hallService.DeleteHall(deleted);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var updated = _hallService.GetById(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Hall Hall)
        {
            TempData["result"] = _hallService.UpdateHall(Hall);
            return RedirectToAction("Index");
        }
    }
}
