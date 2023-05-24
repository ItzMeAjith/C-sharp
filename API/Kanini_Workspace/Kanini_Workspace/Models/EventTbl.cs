using System;
using System.Collections.Generic;

namespace Kanini_Workspace.Models;

public partial class EventTbl
{
    public int EventId { get; set; }

    public string? EventName { get; set; }

    public string? EventDesc { get; set; }

    public DateTime? EventDate { get; set; }

    public int? EventLocid { get; set; }

    public TimeSpan? EventStarttime { get; set; }

    public TimeSpan? EventEndtime { get; set; }

    public virtual LocationTbl? EventLoc { get; set; }

    public virtual EventjoinTbl? EventjoinTbl { get; set; }
}
