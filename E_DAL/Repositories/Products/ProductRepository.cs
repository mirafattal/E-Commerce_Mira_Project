using E_DAL._GenericRepository;
using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceContext ecommerceContext) : base(ecommerceContext)
        {
        }
        public Product GetProductByName(string name)
        {
            var result = _dbSet.Where(x => x.ProductName == name).FirstOrDefault();
            return result;
        }
    }
}
