using E_BLL._GenericService;
using E_BLL.DTOs;
using E_BLL.Rapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Categories
{
    public interface ICategoryService: IGenericService<CategoryDto>
    {
        void AddCategoryWithProducts(CategoryWithProductDto categoryProductDto);
    }
}
