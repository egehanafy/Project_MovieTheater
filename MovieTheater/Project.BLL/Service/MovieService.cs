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

        public string CreateMovie(Movie movie)
        {
            try
            {
                return _movieRepo.Create(movie);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteMovie(Movie movie)
        {
            try
            {
                return _movieRepo.Delete(movie);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Movie> GetAllMovie()
        {
            return _movieRepo.GetAll();
        }

        public Movie GetById(int id)
        {
            return _movieRepo.GetById(id);
        }

        public string UpdateMovie(Movie movie)
        {
            try
            {
                movie.Status = Entity.Enum.Status.Updated;
                return _movieRepo.Update(movie);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
