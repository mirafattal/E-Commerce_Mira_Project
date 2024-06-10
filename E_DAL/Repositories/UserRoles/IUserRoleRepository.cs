using E_DAL._GenericRepository;
using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL.Repositories.UserRoles
{
    public interface IUserRoleRepository: IGenericRepository<UserRole>
    {
        public UserRole GetRoleName(string roleName);
    }
}
