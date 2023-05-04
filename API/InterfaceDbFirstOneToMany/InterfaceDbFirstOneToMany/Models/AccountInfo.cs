using System;
using System.Collections.Generic;

namespace InterfaceDbFirstOneToMany.Models;

public partial class AccountInfo
{
    public int AccountNo { get; set; }

    public string? AccName { get; set; }

    public decimal? Balance { get; set; }

    public virtual ICollection<Transaction>? Transactions { get; set; } = new List<Transaction>();
}
