using AutoMapper;
using E_BLL._GenericService;
using E_BLL.DTOs;
using E_DAL.Models;
using E_DAL.Repositories.UserRoles;
using E_DAL.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.UserRoles
{
    public class UserRoleService: GenericService<UserRole, UserRoleDto>, IUserRoleService
    {
        public readonly IUserRoleRepository _userRoleRepository;
        public readonly IMapper _mapper;

        public UserRoleService(IUserRoleRepository repository, IMapper mapper) : 
            base(repository, mapper)
        {
            _userRoleRepository = repository;
            _mapper = mapper;

        }

        public UserRoleDto GetRoleName(string roleName)
        {
            var result = _userRoleRepository.GetRoleName(roleName);
            return _mapper.Map<UserRoleDto>(result);
        }
    }
}
