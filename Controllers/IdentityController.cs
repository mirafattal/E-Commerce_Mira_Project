using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Commerce_Mira.Controllers
{
    public class User
    {
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }

    [ApiController]
    [Route("[controller]")]

    public class IdentityController : ControllerBase
    {
        private static readonly User[] Users = new[]
    {
        new User(){ Email="accounting@gmail.com", Role="Accounting"},
        new User(){ Email="admin@gmail.com", Role="Admin"},
    };
      


        [AllowAnonymous]
        [HttpGet("GetAllowAnonymous")]
        public string Get()
        {
            return "Accessed Allow Annoymous";
        }

        [Authorize("Admin")]
        [Authorize("Accounting")]
        [HttpGet("GetAdminOrUser")]
        public string GetAllProducts()
        {
            return "Accessed All Products";
        }
      
    }

}
