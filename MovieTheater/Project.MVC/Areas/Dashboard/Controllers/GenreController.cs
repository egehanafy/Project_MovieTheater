using Microsoft.AspNetCore.Mvc;
using Project.BLL.AbstractService;
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
    }
}
