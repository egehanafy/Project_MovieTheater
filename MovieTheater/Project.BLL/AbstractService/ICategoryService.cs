using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.AbstractService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategory();
        string CreateCategory(Category category);
        string DeleteCategory(Category category);
        string UpdateCategory(Category category);
    }
}
