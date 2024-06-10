using E_BLL._GenericService;
using E_BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Products
{
    public interface IProductService: IGenericService<ProductDto> 
    {
        public ProductDto GetProductByName(string name);
    }
}
