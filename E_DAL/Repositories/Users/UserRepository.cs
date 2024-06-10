using E_DAL._GenericRepository;
using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ECommerceContext ecommerceContext) : base(ecommerceContext)
        {
        }
        public User GetUserbyUsername(string username)
        {
            var result = _dbSet.Where(x => x.Username == username).FirstOrDefault();
            return result;
        }
    }
}
