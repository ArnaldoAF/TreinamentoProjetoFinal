using System;
using System.Collections.Generic;
using GAtec.Northwind.Domain;
using GAtec.Northwind.Domain.Business;
using GAtec.Northwind.Domain.Model;
using GAtec.Northwind.Domain.Repository;
using GAtec.Northwind.Util;

namespace GAtec.Northwind.Business
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository CategoryRepository { get; set; }

        public IValidationError Validator { get; set; }

        public CategoryService(ICategoryRepository categoryRepository,
                               IValidationError validator)
        {
            this.CategoryRepository = categoryRepository;
            this.Validator = validator;
        }

        public bool Add(Category category)
        {
            if (string.IsNullOrEmpty(category.Name))
            {
                Validator.AddError("Name", "O nome é obrigatório");
                return false;
            }

            CategoryRepository.Add(category);

            return true;
        }

        public bool Update(Category category)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            var data = CategoryRepository.GetAll();

            return data;
        }
    }
}