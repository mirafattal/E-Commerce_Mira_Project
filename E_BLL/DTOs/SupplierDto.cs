using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.DTOs
{
    public class SupplierDto
    {
        public int SuppliersId { get; set; }

        public string CompanyName { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Adress { get; set; } = null!;

        public int PhoneNumber { get; set; }

        public string Email { get; set; } = null!;
    }
}
