using Project.BLL.Abstract;
using Project.BLL.AbstractService;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.Service
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> _categoryRepo;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepo = categoryRepository;
        }
        public string CreateCategory(Category category)
        {
            try
            {
                return _categoryRepo.Create(category);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteCategory(Category category)
        {
            try
            {
                return _categoryRepo.Delete(category);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _categoryRepo.GetAll();
        }

        public string UpdateCategory(Category category)
        {
            try
            {
                return _categoryRepo.Update(category);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
