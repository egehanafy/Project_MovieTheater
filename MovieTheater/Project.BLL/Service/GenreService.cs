using Project.BLL.Abstract;
using Project.BLL.AbstractService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class GenreService : IGenreService
    {
        private IRepository<Genre> _genreRepo;

        public GenreService(IRepository<Genre> genreRepository)
        {
            _genreRepo = genreRepository;
        }
        public string CreateGenre(Genre genre)
        {
            try
            {
                return _genreRepo.Create(genre);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteGenre(Genre genre)
        {
            try
            {
                return _genreRepo.Delete(genre);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _genreRepo.GetAll();
        }

        public string UpdateGenre(Genre genre)
        {
            try
            {
                return _genreRepo.Update(genre);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
