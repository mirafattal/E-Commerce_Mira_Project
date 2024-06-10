using AutoMapper;
using E_BLL.Exceptions;
using E_BLL.Rapping;
using E_DAL.Repositories.Users;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Auth
{
    public class AuthService: IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public AuthService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }



        public ApiResponse<bool> Login(string username, string password)
        {
            var user = _userRepository.GetUserbyUsername(username);
            if (user == null)
            {
                throw new NotFoundException("Username not found");
            }
            if (user.Password != password)
            {
                throw new NotFoundException("Wrong password");
            }
            return new ApiResponse<bool>();
        }


    }
}
