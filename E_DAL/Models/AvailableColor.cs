using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class AvailableColor
{
    public int AvailableColorId { get; set; }

    public string ColorName { get; set; } = null!;

    public virtual ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
}
