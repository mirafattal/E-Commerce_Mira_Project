using E_BLL._GenericService;
using E_BLL.DTOs;
using E_BLL.Exceptions;
using E_BLL.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Mira.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class ProductController : _GenericController<ProductDto>
    {
        public readonly IProductService _productService;
        public ProductController(IProductService service) : base(service)
        {
            _productService = service;
        }


        [HttpGet("GetProductByName")]
        public ProductDto GetProductByName(string name)
        {
            return _productService.GetProductByName(name);
        }
   
    }
}
