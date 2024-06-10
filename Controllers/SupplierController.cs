using E_BLL.DTOs;
using E_BLL.Services.Products;
using E_BLL.Services.Suppliers;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Mira.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class SupplierController : _GenericController<SupplierDto>
    {
        public readonly ISupplierService _supplierService;
        public SupplierController(ISupplierService service) : base(service)
        {
            _supplierService = service;
        }


    }
}
