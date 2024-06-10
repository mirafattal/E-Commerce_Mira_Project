using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class ProductInventory
{
    public int ProductInventoryId { get; set; }

    public int ProductId { get; set; }

    public int ProductQuantity { get; set; }

    public int MinimumStockLevel { get; set; }

    public int MaximumStockLevel { get; set; }

    public int AvailableSizeId { get; set; }

    public int AvailableColorId { get; set; }

    public virtual AvailableColor AvailableColor { get; set; } = null!;

    public virtual AvailableSize AvailableSize { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
