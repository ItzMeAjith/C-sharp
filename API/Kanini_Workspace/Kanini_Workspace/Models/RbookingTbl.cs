using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class RbookingTbl
{
    public int RbookingId { get; set; }

    public int RoomId { get; set; }

    public string RmeetingDesc { get; set; } = null!;

    public int RbookingLocid { get; set; }

    public int? RbookingEmp { get; set; }

    public DateTime RbookingDate { get; set; }

    public virtual LocationTbl RbookingLoc { get; set; } = null!;

    public virtual RoomTbl Room { get; set; } = null!;
}
