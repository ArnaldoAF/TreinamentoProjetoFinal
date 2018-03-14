using System.Collections.Generic;
using GAtec.Northwind.Domain.Model;
using GAtec.Northwind.Domain.Repository;

namespace GAtec.Northwind.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Add(Category item)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new System.NotImplementedException();
        }

        public Category Get(object id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            var categories = new List<Category>();

            for (int i = 1; i <= 100; i++)
            {
                categories.Add(new Category()
                {
                    Id = i,
                    Name = $"Categoria {i}",
                    Description = $"Descrição da Categoria {i}"
                });
            }

            return categories;
        }
    }
}