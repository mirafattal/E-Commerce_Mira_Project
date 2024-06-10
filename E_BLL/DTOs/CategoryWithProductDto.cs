using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.DTOs
{
    public class CategoryWithProductDto
    {
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public virtual ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
