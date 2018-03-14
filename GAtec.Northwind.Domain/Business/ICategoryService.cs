using System.Collections.Generic;
using GAtec.Northwind.Domain.Model;

namespace GAtec.Northwind.Domain.Business
{
    public interface ICategoryService : IServiceBase
    {
        bool Add(Category category);

        bool Update(Category category);

        bool Delete(int id);

        Category GetCategory(int id);

        IEnumerable<Category> GetCategories();
    }
}