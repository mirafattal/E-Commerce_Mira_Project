using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BLL.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }

        public int UserRoleId { get; set; }

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
