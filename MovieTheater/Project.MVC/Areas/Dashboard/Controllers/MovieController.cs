using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using Project.BLL.IntAbstract;
using Project.BLL.IntService;
using Project.Common;
using Project.Entity.Entity;
using Project.MVC.Areas.Dashboard.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
            _genreService.GetAllGenres().ToList(); //filmlerin kategorisini gostermek icin kategorileride getiriyorum

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
        public async Task<IActionResult> Create(MovieVM movieVM, IFormFile imagePath)
        {
            string path = "";

            var imageResult = ImageUploader.ImageChangeName(imagePath.FileName);

            if (imageResult != "1")
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\image\\movie", imageResult);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await imagePath.CopyToAsync(stream);
                }

                movieVM.ImagePath = imageResult;
            }
            else
            {
                TempData["result"] = "Uyumsuz format";

                return View();
            }

            Movie movie = new Movie
            {
                Title = movieVM.Title,
                Description = movieVM.Description,
                GenreId = movieVM.Genre.Id,
                ImagePath = movieVM.ImagePath
            };

            TempData["result"] = _movieService.CreateMovie(movie);
            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var deleted = _movieService.GetById(id);

            if (deleted != null)
            {
                TempData["result"] = _movieService.DeleteMovie(deleted);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            //SelectListItem => MVC tarafinda bize teslim edilen SelectListItem View icerisinde olusturmus oldugumuz <select></select> etiketi icerisinde selectlist olusturmamizi saglayan bir siniftir.
            ViewBag.Genres = _genreService.GetAllGenres().Select(x => new SelectListItem()
            {
                Text = x.GenreName,
                Value = x.Id.ToString()
            });
            var updated = _movieService.GetById(id);
            return View(updated);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Movie movie, MovieVM movieVM, IFormFile imagePath)
        {
            string path = "";

            var imageResult = ImageUploader.ImageChangeName(imagePath.FileName);

            if (imageResult != "1")
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\image\\movie", imageResult);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imagePath.CopyToAsync(stream);
                }

                movieVM.ImagePath = imageResult;
            }
            else
            {
                TempData["result"] = "Uyumsuz format";

                return View();
            }

                movie.Title = movieVM.Title;
                movie.Description = movieVM.Description;
                movie.GenreId = movieVM.Genre.Id;
                movie.ImagePath = movieVM.ImagePath;

            TempData["result"] = _movieService.UpdateMovie(movie);
            return RedirectToAction("Index");
        }
    }
}
