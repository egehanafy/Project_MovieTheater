using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.BLL.AbstractService;
using Project.BLL.Service;
using Project.Entity.Entity;
using Project.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            //Movie newMovie = new Movie
            //{
            //    Id=2,
            //    MovieName = "Mad Max",
            //    UnitPrice = 0,
            //    UnitsInStock = 0,
            //    UpdatedDate = DateTime.Now,
            //};

            ////var result = _movieService.CreateMovie(newMovie);
            //var result = _movieService.DeleteMovie(newMovie);

            //var movies = _movieService.GetAllMovie().ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}