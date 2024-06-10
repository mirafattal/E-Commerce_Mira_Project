﻿using System;
using System.Collections.Generic;

namespace E_DAL.Models;

public partial class Delivery
{
    public int DeliveryId { get; set; }

    public int OrderId { get; set; }

    public string Location { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
