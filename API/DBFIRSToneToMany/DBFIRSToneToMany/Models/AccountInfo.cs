using System;
using System.Collections.Generic;

namespace DBFIRSToneToMany.Models;

public partial class AccountInfo
{
    public int AccountNo { get; set; }

    public string? AccName { get; set; }

    public decimal? Balance { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public static implicit operator AccountInfo?(Transaction? v)
    {
        throw new NotImplementedException();
    }
}
