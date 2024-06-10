using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class AvailableSize
{
    public int AvailableSizeId { get; set; }

    public string SizeName { get; set; } = null!;

    public virtual ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
}
