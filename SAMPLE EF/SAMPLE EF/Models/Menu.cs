using System;
using System.Collections.Generic;

namespace SAMPLE_EF.Models;

public partial class Menu
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemType { get; set; }

    public decimal? Price { get; set; }

    public string? Offer { get; set; }
}
