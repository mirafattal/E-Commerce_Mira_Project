using AutoMapper;
using E_BLL._GenericService;
using E_BLL.DTOs;
using E_BLL.Rapping;
using E_DAL._GenericRepository;
using E_DAL.Models;
using E_DAL.Repositories.Categories;
using E_DAL.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace E_BLL.Services.Categories
{
    public class CategoryService : GenericService<Category, CategoryDto>, ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;
        

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper,
            IProductRepository productRepository) : 
            base (categoryRepository, mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public void AddCategoryWithProducts(CategoryWithProductDto categoryProductDto)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var category = _mapper.Map<Category>(categoryProductDto);
                    _categoryRepository.Add(category);


                    foreach (var ProductDto in categoryProductDto.Products)
                    {
                        var product = _mapper.Map<Product>(ProductDto);
                        product.CategoryId = category.CategoryId;
                        _productRepository.Add(product);
                    }


                    scope.Complete();
                }
                catch
                {
                    
                    scope.Dispose();
                    throw;
                }
            }
        }
    }
}
