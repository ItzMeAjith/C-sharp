using System;
using System.Collections.Generic;

namespace InterfaceDbFirstOneToMany.Models;

public partial class Transaction
{
    public int TransId { get; set; }

    public int? AccountNo { get; set; }

    public string? Action { get; set; }

    public decimal? ActionAmt { get; set; }

    public virtual AccountInfo? AccountNoNavigation { get; set; }
}
