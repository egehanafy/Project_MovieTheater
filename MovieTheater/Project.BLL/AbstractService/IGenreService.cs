using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.AbstractService
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetAllGenres();
        string CreateGenre(Genre genre);
        string DeleteGenre(Genre genre);
        string UpdateGenre(Genre genre);
    }
}
