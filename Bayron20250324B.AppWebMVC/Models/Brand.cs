﻿using System;
using System.Collections.Generic;

namespace Bayron20250324B.AppWebMVC.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string BrandName { get; set; } = null!;

    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
