using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class UserTbl
{
    public int UserId { get; set; }

    public string? UserEmpid { get; set; }

    public string? UserFirstname { get; set; }

    public string? UserLastname { get; set; }

    public string? UserLocation { get; set; }

    public string? UserDept { get; set; }

    public string? UserTitle { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPhonenumber { get; set; }
}
