using Microsoft.AspNetCore.Mvc;
using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.BLL.Service;
using Project.Entity.Entity;
using Project.MVC.Areas.Dashboard.ViewModels;
using System.Linq;

namespace Project.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class GenreController : Controller
    {
        private IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public IActionResult Index()
        {
            return View(_genreService.GetAllGenres().ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GenreVM genreVM)
        {
            Genre genre = new Genre
            {
                GenreName = genreVM.GenreName
            };

            TempData["result"] = _genreService.CreateGenre(genre);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _genreService.FindGenre(id);

            if (deleted != null)
            {
                TempData["result"] = _genreService.DeleteGenre(deleted);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var updated = _genreService.FindGenre(id);
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Genre genre)
        {
            TempData["result"] = _genreService.UpdateGenre(genre);
            return RedirectToAction("Index");
        }
    }
}
