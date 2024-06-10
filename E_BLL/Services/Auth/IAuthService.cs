using E_BLL.Rapping;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Auth
{
    public interface IAuthService
    {
        ApiResponse<bool> Login(string username, string password);

        
    }
}
