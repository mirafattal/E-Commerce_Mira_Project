using AutoMapper;
using E_BLL._GenericService;
using E_BLL.DTOs;
using E_DAL._GenericRepository;
using E_DAL.Models;
using E_DAL.Repositories.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Suppliers
{
    public class SupplierService: GenericService<Supplier, SupplierDto>, ISupplierService
    {
        public readonly ISupplierRepository _supplierRepository;
        public readonly IMapper _mapper;

        public SupplierService(ISupplierRepository supplierRepository, IMapper mapper) : 
            base(supplierRepository, mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }
    }
}
