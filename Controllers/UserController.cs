using E_BLL.DTOs;
using E_BLL.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Mira.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class UserController : _GenericController<UserDto>
    {
        public readonly IUserService _service;
        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("GetUserbyUsername")]
        public UserDto GetUserbyUsername(string username)
        {
            return _service.GetUserbyUsername(username);
        }
        [HttpPost]
        public bool Login(LoginRequestDto loginRequest)
        {
            return _service.Login(loginRequest);
        }

    }
}
