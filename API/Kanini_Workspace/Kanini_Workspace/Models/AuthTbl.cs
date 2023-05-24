using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class AuthTbl
{
    public int AuthId { get; set; }

    public string? AuthEmpid { get; set; }

    public string? AuthEmail { get; set; }

    public string? AuthPassword { get; set; }
}
