using System;
using System.Collections.Generic;

namespace DBFirst_Web_API.Models;

public partial class Menu
{
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public double ItemPrice { get; set; }

    public int ItemCount { get; set; }
}
