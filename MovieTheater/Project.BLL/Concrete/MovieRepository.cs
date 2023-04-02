using Project.BLL.Abstract;
using Project.DAL.Context;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.BLL.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            ProjectContext _db = new ProjectContext();
            return _db.Movies.ToList();
        }
    }
}
