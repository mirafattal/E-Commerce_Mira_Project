using E_BLL.DTOs;
using E_BLL.Services.Categories;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Mira.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class CategoryController : _GenericController<CategoryDto>
    {
        public readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService service) : base(service)
        {
            _categoryService = service;
        }

        [HttpPost("AddCategoryProduct")]
        public void AddCategoryWithProducts(CategoryWithProductDto categoryProductDto)
        {
             _categoryService.AddCategoryWithProducts(categoryProductDto);
        }
    }
}
