using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class DbookingTbl
{
    public int DbookingId { get; set; }

    public int DbookingLocid { get; set; }

    public DateTime DbookingDate { get; set; }

    public string DbookingColl { get; set; } = null!;

    public virtual LocationTbl DbookingLoc { get; set; } = null!;
}
