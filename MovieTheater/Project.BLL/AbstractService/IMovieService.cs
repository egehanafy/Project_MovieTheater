using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.AbstractService
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllMovie();
    }
}
