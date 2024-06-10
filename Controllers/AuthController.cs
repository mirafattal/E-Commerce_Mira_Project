using E_BLL.DTOs;
using E_BLL.Rapping;
using E_BLL.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Mira.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost]
        public ApiResponse<bool> Login(LoginRequestDto loginRequestdto)
        {
            return _authService.Login(loginRequestdto.Username, loginRequestdto.Password);
        }

    }
}
