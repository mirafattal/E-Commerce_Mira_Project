using E_DAL._GenericRepository;
using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL.Repositories.Products
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Product GetProductByName(string name);
    }
}
