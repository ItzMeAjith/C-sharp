using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class RoomTbl
{
    public int RoomId { get; set; }

    public string RoomName { get; set; } = null!;

    public int RoomCapacity { get; set; }

    public string Presentation { get; set; } = null!;

    public string Additional { get; set; } = null!;

    public int RoomLocid { get; set; }

    public virtual ICollection<RbookingTbl> RbookingTbls { get; set; } = new List<RbookingTbl>();

    public virtual LocationTbl RoomLoc { get; set; } = null!;
}
