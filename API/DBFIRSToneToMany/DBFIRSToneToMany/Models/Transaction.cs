using System;
using System.Collections.Generic;

namespace DBFIRSToneToMany.Models;

public partial class Transaction
{
    internal readonly object AccountInfos;

    public int TransId { get; set; }

    public int? AccountNo { get; set; }

    public string? Action { get; set; }

    public decimal? ActionAmt { get; set; }

    public virtual AccountInfo? AccountNoNavigation { get; set; }
}
