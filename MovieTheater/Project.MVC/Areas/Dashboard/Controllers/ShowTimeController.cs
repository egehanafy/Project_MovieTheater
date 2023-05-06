using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.BLL.IntService;
using Project.BLL.Service;
using Project.Entity.Entity;
using Project.MVC.Areas.Dashboard.ViewModels;
using System.Linq;

namespace Project.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ShowTimeController : Controller
    {
        private readonly IShowTimeService _showTimeService;
        private readonly IMovieService _movieService;
        private readonly IHallService _hallService;

        public ShowTimeController(IShowTimeService showTimeService, IMovieService movieService, IHallService hallService)
        {
            _showTimeService = showTimeService;
            _movieService = movieService;
            _hallService = hallService;
        }
        public IActionResult Index()
        {
            return View(_showTimeService.GetAllShowTime().ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Movies = _movieService.GetAllMovie().Select(x => new SelectListItem()
            {
                Text = x.Title,
                Value = x.Id.ToString()
            });
            ViewBag.Halls = _hallService.GetAllHalls().Select(x => new SelectListItem()
            {
                Text = x.No,
                Value = x.Id.ToString()
            });
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShowTimeVM showTimeVM)
        {
            ShowTime showTime = new ShowTime
            {
                Time = showTimeVM.Time,
                MovieId = showTimeVM.Movie.Id,
                HallId = showTimeVM.Hall.Id
            };

            TempData["result"] = _showTimeService.CreateShowTime(showTime);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _showTimeService.FindShowTime(id);

            if (deleted != null)
            {
                TempData["result"] = _showTimeService.DeleteShowTime(deleted);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ViewBag.Movies = _movieService.GetAllMovie().Select(x => new SelectListItem()
            {
                Text = x.Title,
                Value = x.Id.ToString()
            });
            ViewBag.Halls = _hallService.GetAllHalls().Select(x => new SelectListItem()
            {
                Text = x.No,
                Value = x.Id.ToString()
            });
            var updated = _showTimeService.FindShowTime(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(ShowTime showTime)
        {
            TempData["result"] = _showTimeService.UpdateShowTime(showTime);
            return RedirectToAction("Index");
        }
    }
}
