﻿using E_DAL._GenericRepository;
using E_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL.Repositories.Users
{
    public interface IUserRepository: IGenericRepository<User>
    {
        public User GetUserbyUsername(string username);
    }
}
