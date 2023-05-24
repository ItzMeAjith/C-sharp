using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class LocationTbl
{
    public int LocationId { get; set; }

    public string LocationCity { get; set; } = null!;

    public virtual ICollection<DbookingTbl> DbookingTbls { get; set; } = new List<DbookingTbl>();

    public virtual ICollection<EventTbl> EventTbls { get; set; } = new List<EventTbl>();

    public virtual ICollection<NotificationTbl> NotificationTbls { get; set; } = new List<NotificationTbl>();

    public virtual ICollection<RbookingTbl> RbookingTbls { get; set; } = new List<RbookingTbl>();

    public virtual ICollection<RoomTbl> RoomTbls { get; set; } = new List<RoomTbl>();
}
