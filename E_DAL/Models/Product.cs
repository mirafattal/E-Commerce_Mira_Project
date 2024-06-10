using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int SupplierId { get; set; }

    public int CategoryId { get; set; }

    public string UnitPrice { get; set; } = null!;

    public int BarCode { get; set; }

    public string? ProductDescription { get; set; }

    public decimal UnitWeight { get; set; }

    public decimal UnitHeight { get; set; }

    public bool DisccountAvailable { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();

    public virtual Supplier Supplier { get; set; } = null!;
}
