using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.Services.Authorization
{
    public class RoleRequirement: IAuthorizationRequirement
    {
        public RoleRequirement(string role) => Role = role;

        public string Role { get; }
    }
}
