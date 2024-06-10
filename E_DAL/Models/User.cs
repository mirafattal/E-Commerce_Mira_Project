using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int UserRoleId { get; set; }

    public string UserCountry { get; set; } = null!;

    public string UserAdress { get; set; } = null!;

    public int UserPhone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual UserRole UserRole { get; set; } = null!;
}
