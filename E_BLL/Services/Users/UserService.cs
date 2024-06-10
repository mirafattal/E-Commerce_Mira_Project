using AutoMapper;
using E_BLL._GenericService;
using E_BLL.DTOs;
using E_DAL.Models;
using E_DAL.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Users
{
    public class UserService: GenericService<User, UserDto>, IUserService
    {
        public readonly IUserRepository _userRepository;
        public readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _userRepository = repository;
            _mapper = mapper;

        }

        public UserDto GetUserbyUsername(string username)
        {
            var result = _userRepository.GetUserbyUsername(username);
            return _mapper.Map<UserDto>(result);

        }
        public bool Login(LoginRequestDto loginRequestDto)
        {
            var username = loginRequestDto.Username;
            var user = _userRepository.GetUserbyUsername(username);

            if (user == null)
            {
                return false;
            }
            else if (user.Password == loginRequestDto.Password)
            {

                return true;

            }
            return false;
        }
    }
}
