using Project.BLL.Abstract;
using Project.BLL.AbstractService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class MovieService : IMovieService
    {
        private IRepository<Movie> _movieRepo;

        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepo = movieRepository;
        }

        public IEnumerable<Movie> GetAllMovie()
        {
            return _movieRepo.GetAll();
        }
    }
}
