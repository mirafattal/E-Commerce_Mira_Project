using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Privileges { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
