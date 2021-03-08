using ExerciseProject.Models.Dtos;
using ExerciseProject.Models.Entities;
namespace ExerciseProject.Repositories.ProductCategories
{
    public interface ProductCategoryRepository
    {
        void AddProductCategory(AddProductCategoryDto categoryDto);
    }
}