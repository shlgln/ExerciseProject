using ExerciseProject.DataBaseCon;
using ExerciseProject.Models.Dtos;
using ExerciseProject.Models.Entities;
using System;
using System.Linq;

namespace ExerciseProject.Repositories.ProductCategories
{
    public class EFProductCategory : ProductCategoryRepository
    {
        private readonly DataBaseContext _context;
        public EFProductCategory(DataBaseContext context)
        {
            _context = context;
        }
        public void AddProductCategory(AddProductCategoryDto categoryDto)
        {
            if (categoryDto.ParentId == null)
            {
                if (_context.productCategories.Any(_ => _.Title == categoryDto.Title))
                    throw new Exception();
            }
            else
            {
                if (_context.productCategories.Any(_ => _.ParentId == categoryDto.ParentId && _.Title == categoryDto.Title))
                    throw new Exception();
            }


            var productCategory = new ProductCategory
            {
                Title = categoryDto.Title,
                ParentId = categoryDto.ParentId
            };
            _context.Add(productCategory);
        }
    }
}
