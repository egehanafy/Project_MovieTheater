using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.BLL.AbstractService;
using Project.Entity.Entity;
using Project.MVC.Areas.Dashboard.ViewModels;
using System.Linq;

namespace Project.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;

        public MovieController(IMovieService movieService, IGenreService genreService)
        {
            _movieService = movieService;
            _genreService = genreService;
        }

        public IActionResult Index()
        {
            return View(_movieService.GetAllMovie().ToList());
        }

        public IActionResult Create()
        {
            //SelectListItem => MVC tarafinda bize teslim edilen SelectListItem View icerisinde olusturmus oldugumuz <select></select> etiketi icerisinde selectlist olusturmamizi saglayan bir siniftir.
            ViewBag.Genres = _genreService.GetAllGenres().Select(x=> new SelectListItem()
            {
                Text=x.GenreName,
                Value=x.Id.ToString()
            });
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieVM movieVM)
        {
            Movie movie = new Movie
            {
                Title = movieVM.Title,
                Description = movieVM.Description,
                GenreId = movieVM.Genre.Id
            };

            TempData["result"] = _movieService.CreateMovie(movie);
            
            return RedirectToAction("Index");
        }
    }
}
