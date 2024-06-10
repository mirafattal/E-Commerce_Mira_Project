using AutoMapper;
using E_BLL._GenericService;
using E_BLL.DTOs;
using E_DAL._GenericRepository;
using E_DAL.Models;
using E_DAL.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Products
{
    public class ProductService : GenericService<Product, ProductDto>, IProductService
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _productRepository = repository;
            _mapper = mapper;
        }

        public ProductDto GetProductByName(string name)
        {
            var result = _productRepository.GetProductByName(name);
            return _mapper.Map<ProductDto>(result);
        }
    }
}
