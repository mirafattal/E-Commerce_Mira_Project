using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.DTOs
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

        public string UnitPrice { get; set; } = null!;

        public int BarCode { get; set; }

        public string? ProductDescription { get; set; }

        public decimal UnitWeight { get; set; }

        public decimal UnitHeight { get; set; }

        public bool DisccountAvailable { get; set; }

      
    }
}
