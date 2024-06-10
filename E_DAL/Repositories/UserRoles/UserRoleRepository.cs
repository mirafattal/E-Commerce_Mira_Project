using E_DAL._GenericRepository;
using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL.Repositories.UserRoles
{
    public class UserRoleRepository: GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(ECommerceContext ecommerceContext) : base(ecommerceContext)
        {
        }

        public UserRole GetRoleName(string roleName)
        {
            var result = _dbSet.Where(x => x.RoleName == roleName).FirstOrDefault();
            return result;

        }
    }
}
