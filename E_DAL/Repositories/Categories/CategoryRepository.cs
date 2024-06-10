using E_DAL._GenericRepository;
using E_DAL.Models;
using E_DAL.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceContext ecommerceContext) : base(ecommerceContext)
        {
        }
    }
}
