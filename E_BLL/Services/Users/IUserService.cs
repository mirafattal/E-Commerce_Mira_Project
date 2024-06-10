using E_BLL._GenericService;
using E_BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Users
{
    public interface IUserService: IGenericService<UserDto>
    {
        public UserDto GetUserbyUsername(string username);
        public bool Login(LoginRequestDto loginRequestDto);
    }
}
