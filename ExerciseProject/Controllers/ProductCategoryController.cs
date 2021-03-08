using ExerciseProject.Models.Dtos;
using ExerciseProject.Repositories.ProductCategories;
using ExerciseProject.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseProject.Controllers
{
    [Route("api/product-category")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly UnitOfWorkRepository _unitofwork;
        private readonly ProductCategoryRepository _productCategoryRepository;
        public ProductCategoryController(ProductCategoryRepository productCategoryRepository, UnitOfWorkRepository unitOfWork)
        {
            _productCategoryRepository = productCategoryRepository;
            _unitofwork = unitOfWork;
        }


        [HttpPost]
        public void Add(AddProductCategoryDto categoryDto)
        {
            _productCategoryRepository.AddProductCategory(categoryDto);
            _unitofwork.complete();
        }
    }
}
