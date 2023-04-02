using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Abstract
{
    public interface IMovieRepository
    {
        public List<Movie> GetAll();
    }
}
