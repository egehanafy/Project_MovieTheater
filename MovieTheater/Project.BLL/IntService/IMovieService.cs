using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.IntService
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllMovie();
        string CreateMovie(Movie movie);
        string DeleteMovie(Movie movie);
        string UpdateMovie(Movie movie);
        Movie GetById(int id);
    }
}
