using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class Supplier
{
    public int SuppliersId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
